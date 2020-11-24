/* 
Licensed under the Apache License, Version 2.0

http://www.apache.org/licenses/LICENSE-2.0
*/
using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Xml;

namespace Xml2CSharp
{
    [XmlRoot(ElementName = "QuestionBlock")]
    public class QuestionBlock
    {
        [XmlElement(ElementName = "Question")]
        public string Question { get; set; }
        [XmlElement(ElementName = "TrueAnswer")]
        public string TrueAnswer { get; set; }
        [XmlElement(ElementName = "DifficultLevel")]
        public int DifficultLevel { get; set; }
        [XmlElement(ElementName = "Q1")]
        public string Q1 { get; set; }
        [XmlElement(ElementName = "Q2")]
        public string Q2 { get; set; }
        [XmlElement(ElementName = "Q3")]
        public string Q3 { get; set; }

        public override string ToString()
        {
            return $"{Question}";
        }

        public void ReaderQuestionBloc(XmlTextReader reader)
        {
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Question":
                            reader.Read();
                            this.Question = reader.Value;
                            break;

                        case "TrueAnswer":
                            reader.Read();
                            this.TrueAnswer = reader.Value;
                            break;

                        case "Q1":
                            reader.Read();
                            this.Q1 = reader.Value;
                            break;

                        case "Q2":
                            reader.Read();
                            this.Q2 = reader.Value;
                            break;

                        case "Q3":
                            reader.Read();
                            this.Q3 = reader.Value;
                            break;

                        case "DifficultLevel":
                            reader.Read();
                            this.DifficultLevel = int.Parse(reader.Value);
                            break;

                        default:
                            break;
                    }
                }
            }
        }
    }

    [XmlRoot(ElementName = "Test")]
    public class Test
    {
        [XmlElement(ElementName = "TestName")]
        public string TestName { get; set; }
        [XmlElement(ElementName = "QuestionBlock")]
        public List<QuestionBlock> QuestionBlocks { get; set; }

        public override string ToString()
        {
            return $"{TestName}";
        }
    }

    [XmlRoot(ElementName = "Tests")]
    public class Tests
    {
        [XmlElement(ElementName = "Test")]
        public List<Test> TestsList { get; set; }
    }

}


