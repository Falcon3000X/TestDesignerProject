/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */
using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace Xml2CSharp
{
    [XmlRoot(ElementName = "Group")]
    public class Group
    {
        [XmlElement(ElementName = "GroupName")]
        public string GroupName { get; set; }
        [XmlElement(ElementName = "Users")]
        public List<User> Users { get; set; }
    }

}

