using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSystemNS
{
    public class Video : MultimediaDocument, IDocument
    {
        private string frate;
        public string FRate
        {
            get
            {
                return this.frate;
            }
            protected set
            {
                this.frate = value;
            }
        }

        public override void LoadProperty(string key, string value)
        {
            if (key == "framerate")
            {
                this.FRate = value;
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("framerate", this.FRate));
        }
    }
}
