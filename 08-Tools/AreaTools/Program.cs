using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTools
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var fileStream = new FileStream("城市代码.txt", FileMode.OpenOrCreate))
            {
                using (var reader = new StreamReader(fileStream))
                {
                    var json = reader.ReadToEnd();
                    var city = Newtonsoft.Json.JsonConvert.DeserializeObject<CnCity>(json);
                    WriteEnumsFile(city.items, "CnCity");
                }
            }

            using (var fileStream = new FileStream("地区代码.txt", FileMode.OpenOrCreate))
            {
                using (var reader = new StreamReader(fileStream))
                {
                    var json = reader.ReadToEnd();
                    var city = Newtonsoft.Json.JsonConvert.DeserializeObject<CnArea>(json);
                    WriteEnumsFile(city.items, "CnArea");
                }
            }

            using (var fileStream = new FileStream("国家代码.txt", FileMode.OpenOrCreate))
            {
                using (var reader = new StreamReader(fileStream))
                {
                    var json = reader.ReadToEnd();
                    var city = Newtonsoft.Json.JsonConvert.DeserializeObject<WDCountry>(json);
                    WriteEnumsFile(city.items, "WDCountry");
                }
            }

            using (var fileStream = new FileStream("省份代码.txt", FileMode.OpenOrCreate))
            {
                using (var reader = new StreamReader(fileStream))
                {
                    var json = reader.ReadToEnd();
                    var city = Newtonsoft.Json.JsonConvert.DeserializeObject<CnProvince>(json);
                    WriteEnumsFile(city.items, "CnProvince");
                }
            }

        }

        /// <summary>
        /// 写枚举
        /// </summary>
        /// <param name="areas"></param>
        /// <param name="typePath"></param>
        static void WriteEnumsFile(IEnumerable<Item> areas, string typePath)
        {
            var builder = new StringBuilder();
            builder.Append($"public enum {typePath}");
            builder.Append(Environment.NewLine);
            builder.Append("{");
            foreach (var area in areas)
            {
                builder.Append($"        /// <summary>");
                builder.Append(Environment.NewLine);
                builder.Append($"        /// {area._name}");
                builder.Append(Environment.NewLine);
                builder.Append($"        /// <summary>");
                builder.Append(Environment.NewLine);
                builder.Append($"        _{area.key} = {area.key},");
                builder.Append(Environment.NewLine);
                builder.Append(Environment.NewLine);
            }
            builder.Append("}");
            var path = $"{typePath}.cs";
            using (var fileStream = new FileStream(path, FileMode.OpenOrCreate))
            {
                var enumStr = builder.ToString();
                var enumBytes = Encoding.UTF8.GetBytes(enumStr);
                fileStream.Write(enumBytes, 0, enumBytes.Length);
            }
        }
    }
}
