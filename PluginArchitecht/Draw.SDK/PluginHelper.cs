using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Draw.SDK
{
    public static class PluginHelper
    {
        public static List<Plug> GetPlugins(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentException(nameof(path));
            }

            if (!Directory.Exists(path))
            {
                throw new FileNotFoundException($"{path} klasör yolu yanlış");

            }
            var plugs =  GetPluginsInPath(path);
            return plugs;
        }

        private static List<Plug> GetPluginsInPath(string path)
        {
          
            var dllFiles = Directory.GetFiles(path, "*.dll", SearchOption.AllDirectories);
            List<Plug> plugs = new List<Plug>();
            dllFiles?.ToList().ForEach(file =>  AddReference(file,plugs));
            return plugs;
        }

        private static void AddReference(string file, List<Plug> plugs)
        {
            
            Assembly assembly = Assembly.LoadFile(file);
            var types = assembly.GetTypes();
            types?.ToList().ForEach(type =>
            {
                Plug plug = handshakeForApp(type, file);
                if (plug != null)
                {
                    plugs.Add(plug);
                }
            });

          
        }

        private static Plug handshakeForApp(Type type, string file)
        {
            Plug plug = null;
            if (type.GetInterface("IPlug") != null)
            {
                plug = new Plug();
                plug.FullName = type.FullName;
                plug.Path = file;
                dynamic instance = Activator.CreateInstance(type);
                //plug.Name = (string)instance.GetType().InvokeMember("Name", BindingFlags.GetProperty, null, instance, null);
                plug.Name = instance.Name;

            }
            return plug;

        }

        public static object CreateInstance(Plug plug)
        {
            Assembly assembly = Assembly.LoadFile(plug.Path);
            var instance = assembly.CreateInstance(plug.FullName);
            return instance;
        }
    }
}
