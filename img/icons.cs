using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;

namespace ow.img
{
    public class icons
    {
        private Dictionary<string, Image> _value = null;
        public Image this[string key] => _value[key];

        public static icons Read { get; set; }

        public icons()
        {
            _value = new Dictionary<string, Image>();
            var names = Assembly.GetExecutingAssembly().GetManifestResourceNames().Where(x => x.EndsWith(".png")).ToArray();
            foreach (var n in names)
            {
                var val = loadRes(n);
                _value[val.name] = val.img;
            }
        }

        private dynamic loadRes(string n)
        {
            Image _img = null;
            string _nam = "";
            using (var _stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(n))
            {
                _img = Image.FromStream(_stream);
                _nam = n.Split('.')[2];
            }
            return new { img = _img, name = _nam };
        }
    }

}