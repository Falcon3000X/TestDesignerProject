/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */
using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace Xml2CSharp
{
	[XmlRoot(ElementName = "User")]
	public class User
	{
		[XmlElement(ElementName = "Login")]
		public string Login { get; set; }
		[XmlElement(ElementName = "Password")]
		public string Password { get; set; }
		[XmlElement(ElementName = "IsAdmin")]
		public bool IsAdmin { get; set; }
	}

}
