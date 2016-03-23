using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlMarkupBuilderLibrary
{
    public class XmlMarkupBuilder
    {
        private Stack<string> tags = new Stack<string>();
        private StringBuilder result = new StringBuilder();
        private Dictionary<String, String> tagAttr = new Dictionary<string, string>();
        private string identation = "   ";

        private int tagCounter = 0;
        private int maxTagCounter = 0;
        private string replacer = ".";
        private bool canAddText = true;

        public void openTag(String tagName)
        {
            if (tags.Count == 0)
            {
                string tagWithRowNumber = tagName + tagCounter + replacer;
                tags.Push(tagWithRowNumber);
                result.Append("<" + tagWithRowNumber + ">");
            }
            else
            {
                string tagWithRowNumber = tagName + tagCounter + replacer;
                string tabs = string.Concat(Enumerable.Repeat(identation, tags.Count));
                tags.Push(tagWithRowNumber);
                result.Append(Environment.NewLine + tabs + "<" + tagWithRowNumber + ">");
            }
            
            tagCounter++;
            maxTagCounter++;
        }

        public void addAttr(String attrName, String attrValue)
        {
            if(tags.Count == 0)
            {
                throw new InvalidOperationException("You cannot add attributes without having an opened tag!");
            }
            else if(tagAttr.ContainsKey(tags.Peek()))
            {
                string tagAndAttrOld = tags.Peek() + " " + tagAttr[tags.Peek()];
                string tagAndAttrNew = tags.Peek() + " " + attrName + "=\"" + attrValue + "\"";

                result.Replace(tagAndAttrOld, tagAndAttrNew);
            }
            else
            {
                string tagWithoutAttr = tags.Peek();
                string tagWithAttr = tags.Peek() + " " + attrName + "=\"" + attrValue + "\"";

                result.Replace(tagWithoutAttr, tagWithAttr);
                tagAttr.Add(tags.Peek(), attrName + "=\"" + attrValue + "\"");
            }
        }

        public void addText(String text)
        {
            if(tags.Count == 0)
            {
                throw new InvalidOperationException("You cannot add text without having an opened tag!");
            }
            else if(canAddText == false)
            {
                throw new InvalidOperationException("You cannot add text after performing a close tag operation!");
            }
            else
            {
                result.Append(text);
            }
        }

        public void closeTag()
        {
            try
            {
                if(tagCounter < maxTagCounter)
                {
                    string tag = tags.Pop();
                    string tabs = string.Concat(Enumerable.Repeat(identation, tags.Count));
                    result.Append(Environment.NewLine + tabs + "</" + tag + ">");

                    string correctTag = tag.Substring(0, tag.Length - (replacer.Length + tagCounter.ToString().Length));
                    result.Replace(tag, correctTag);
                }
                else
                {
                    string tag = tags.Pop();
                    result.Append("</" + tag + ">");

                    string correctTag = tag.Substring(0, tag.Length - (replacer.Length + tagCounter.ToString().Length));
                    result.Replace(tag, correctTag);
                }

                canAddText = false;
                tagCounter--;
            }
            catch (InvalidOperationException ex) 
            {
                Console.WriteLine("There are no more tags to be closed!");
            }
        }

        public void finalize()
        {
            if (tags.Count > 0)
            {
                while (tags.Count > 0)
                {
                    closeTag();
                }
            }
            else 
            {
                throw new InvalidOperationException("There are no more tags to be closed!");
            }
        }

        public void GetResult()
        {
            if (result.Length == 0)
            {
                throw new InvalidOperationException("XML Markup Builder is empty!");
            }
            else if (tags.Count > 0)
            {
                throw new InvalidOperationException("Your XML Markup Builder is not yet finalized!");
            }
            else
            {
                Console.WriteLine(result.ToString());
            }
        }
    }
}
