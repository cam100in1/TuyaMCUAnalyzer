using System.Xml.Linq;

namespace DatapointDecoder
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Linq;


    public class SpecificationReader
    {
        public static (List<DatapointSpec>, Dictionary<string, EnumSpec>) ReadSpecification(string xmlFilePath)
        {
            var datapointSpecs = new List<DatapointSpec>();
            var enumSpecs = new Dictionary<string, EnumSpec>();
            var xmlDoc = XDocument.Load(xmlFilePath);

            // Erstes <Headline>-Element auslesen
            var headline = xmlDoc.Root.Element("Headline");

            string name = (string)headline.Attribute("name");
            string type = (string)headline.Attribute("type");
            string version = (string)headline.Attribute("version");
            string owner = (string)headline.Attribute("owner");

            if (DatapointDecoder.MessageDecoder.requieredType == type && DatapointDecoder.MessageDecoder.requieredVersion == version)
            {

                foreach (var enumElement in xmlDoc.Descendants("Enum"))
                {
                    var enumSpec = new EnumSpec
                    {
                        Name = enumElement.Attribute("name").Value,
                        Values = []
                    };

                    foreach (var valueElement in enumElement.Elements("Value"))
                    {
                        var enumValue = new EnumValue
                        {
                            Name = valueElement.Attribute("name").Value,
                            Value = int.Parse(valueElement.Attribute("value").Value)
                        };

                        enumSpec.Values.Add(enumValue);
                    }

                    enumSpecs[enumSpec.Name] = enumSpec;
                }

                foreach (var dpElement in xmlDoc.Descendants("Datapoint"))
                {
                    var datapointSpec = new DatapointSpec
                    {
                        Id = dpElement.Attribute("id").Value,
                        Name = dpElement.Attribute("name").Value,
                        Items = []
                    };

                    foreach (var itemElement in dpElement.Elements("Item"))
                    {
                        var specItem = new SpecItem
                        {
                            Id = itemElement.Attribute("id").Value,
                            Position = int.Parse(itemElement.Attribute("position").Value),
                            Length = int.Parse(itemElement.Attribute("length").Value),
                            Type = itemElement.Attribute("type").Value,
                            EnumType = itemElement.Attribute("enumType")?.Value
                        };

                        datapointSpec.Items.Add(specItem);
                    }

                    var blockElement = dpElement.Element("Block");
                    if (blockElement != null)
                    {
                        var blockSpec = new BlockSpec
                        {
                            Items = []
                        };

                        foreach (var blockItemElement in blockElement.Elements("Item"))
                        {
                            var blockSpecItem = new SpecItem
                            {
                                Id = blockItemElement.Attribute("id").Value,
                                Position = int.Parse(blockItemElement.Attribute("position").Value),
                                Length = int.Parse(blockItemElement.Attribute("length").Value),
                                Type = blockItemElement.Attribute("type").Value,
                                EnumType = blockItemElement.Attribute("enumType")?.Value
                            };

                            blockSpec.Items.Add(blockSpecItem);
                        }

                        datapointSpec.Block = blockSpec;
                    }

                    datapointSpecs.Add(datapointSpec);
                }

                return (datapointSpecs, enumSpecs);
            }
            else
            {
                throw new FormatException($"Version missmatch: requiered type: {DatapointDecoder.MessageDecoder.requieredType} type is: {type} and requiered version: {DatapointDecoder.MessageDecoder.requieredVersion} version is: {version}");
            }
        }
    }

}