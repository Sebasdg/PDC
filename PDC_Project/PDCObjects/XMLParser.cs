using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Xml;
using System.Xml.Schema;

namespace PDCObjects {
	public static class XMLParser {

		public static void LoadXML(string xmlLocation, out XmlDocument xmlDoc) {
			XmlDocument doc = new XmlDocument();

			try {
				doc.Load(xmlLocation);
				xmlDoc = doc;
			}
			catch (Exception ex) {
				throw ex;
			}
		}

		public static Container[] XMLToContainers(XmlDocument xmlDoc) {
			XmlNodeList ContainerNodes = xmlDoc.ChildNodes;
			List<Container> containers = new List<Container>();

			//Go through all container nodes
			for (int i = 0; i < ContainerNodes.Count; i++) {
				if (ContainerNodes[i].Name != "Container") {
					continue;
				}

				XmlNodeList containerInfo = ContainerNodes[i].ChildNodes;
				string id = "";
				string date = "";
				XmlNodeList parcelParent = null;

				//Fill container info
				for (int x = 0; x < containerInfo.Count; x++) {
					if (containerInfo[x].Name == "Id")
						TryGetStringFromNode(containerInfo[x], out id);
					if (containerInfo[x].Name == "ShippingDate")
						TryGetStringFromNode(containerInfo[x], out date);

					//Get all parcel nodes from the parcels parent
					if (containerInfo[x].Name == "parcels") {
						parcelParent = containerInfo[x].ChildNodes;
					}
				}

				//Set the info for this container
				int.TryParse(id, out int idNumber);
				DateTimeOffset.TryParse(date, out DateTimeOffset dateTime);

				Container container = new Container();
				container.SetContainerInfo(idNumber, dateTime);

				if (parcelParent != null) {
					XmlNodeList parcelNodes = parcelParent;
					List<Parcel> parcels = new List<Parcel>();

					//Go through all parcel nodes
					for (int x = 0; x < parcelNodes.Count; x++) {
						XmlNodeList parcelInfo = parcelNodes[x].ChildNodes;

						XmlNode senderNode = null;
						XmlNode recipientNode = null;
						string weight = "";
						string value = "";

						//Go through all parcel information nodes
						for (int y = 0; y < parcelInfo.Count; y++) {
							if (parcelInfo[y].Name == "Sender")
								senderNode = parcelInfo[y];
							//Receipient??
							if (parcelInfo[y].Name == "Receipient")
								recipientNode = parcelInfo[y];
							if (parcelInfo[y].Name == "Weight")
								TryGetStringFromNode(parcelInfo[y], out weight);
							if (parcelInfo[y].Name == "Value")
								TryGetStringFromNode(parcelInfo[y], out value);
						}

                        //set parcel information
                        var newWeight = float.Parse(weight, new CultureInfo("en-US"));
                        float.TryParse(value, out float parcelValue);

						LegalEntity sender = SetLegalEnity(senderNode);
						LegalEntity recipient = SetLegalEnity(recipientNode);

						Parcel parcel = new Parcel();
						parcel.SetValues(newWeight, parcelValue, container);
						parcel.SetLegalEntities(sender, recipient);
						parcels.Add(parcel);
					}
					container.SetParcels(parcels.ToArray());
				}
				containers.Add(container);
			}
			return containers.ToArray();
		}

		public static LegalEntity SetLegalEnity ( XmlNode entityNode){
			XmlNodeList legalEntityInfo = entityNode.ChildNodes;
			XMLNodeTypeToLegalEntity(entityNode, out LegalEntity legalEntity);

			string Name = "";
			string CcNumber = "";
			XmlNode Address = null;

			//Go through all legal entity nodes
			for (int y = 0; y < legalEntityInfo.Count; y++) {
				if (legalEntityInfo[y].Name == "Name")
					TryGetStringFromNode(legalEntityInfo[y], out Name);
				if (legalEntityInfo[y].Name == "CcNumber")
					TryGetStringFromNode(legalEntityInfo[y], out CcNumber);
				if (legalEntityInfo[y].Name == "Address")
					Address = legalEntityInfo[y];
			}

			//set legal intity information
			int.TryParse(CcNumber, out int companyCcNumber);

			if (legalEntity is Company) {
				Company company = (Company)legalEntity;
				company.SetValues(Name, companyCcNumber);
				legalEntity = company;
			}
			else {
				legalEntity.SetValues(Name);
			}

			if (Address != null) {
				XmlNodeList AddressInfo = Address.ChildNodes;

				string street = "";
				string houseNumber = "";
				string postalCode = "";
				string city = "";

				//Go through all address nodes
				for (int y = 0; y < AddressInfo.Count; y++) {
					if (AddressInfo[y].Name == "Street")
						TryGetStringFromNode(AddressInfo[y], out street);
					if (AddressInfo[y].Name == "HouseNumber")
						TryGetStringFromNode(AddressInfo[y], out houseNumber);
					if (AddressInfo[y].Name == "PostalCode")
						TryGetStringFromNode(AddressInfo[y], out postalCode);
					if (AddressInfo[y].Name == "City")
						TryGetStringFromNode(AddressInfo[y], out city);
				}

				int.TryParse(houseNumber, out int houseNr);
				string newPostalCode = postalCode;
				if (newPostalCode.Contains(" ")) {
					newPostalCode = newPostalCode.Replace(" ", string.Empty);
				}
				Address address = new Address();
				address.SetValues(street,houseNr, newPostalCode, city);
				legalEntity.SetAddress(address);
			}
			return legalEntity;
		}

		public static void TryGetStringFromNode(XmlNode Node, out string text) {
			if (Node.InnerText != null) {
				text = Node.InnerText;
			}
			else {
				//Console.WriteLine("    " + Node.Name + " does not contain inner text");
				text = string.Empty;
			}
		}

		public static void XMLNodeTypeToLegalEntity(XmlNode Node, out LegalEntity legalEntity) {
			if (Node.Attributes.Count == 0) {
				legalEntity = new Person();
				return;
			}

			switch (Node.Attributes["xsi:type"].Value) {
				case "Company":
					legalEntity = new Company();
					break;
				default:
					legalEntity = new Person();
					break;
			}
		}
	}
}