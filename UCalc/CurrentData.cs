using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UValue;
using Component = UValue.Component;

namespace UCalc
{
    public static class Storage
    {
        private static List<Component> components = new List<Component>();
        private static List<Material> materials = new List<Material>();

        private static string filePath;

        public static event EventHandler ComponentsChanged;
        public static event EventHandler MaterialsChanged;

        public static void AddComponent(Component component)
        {
            components.Add(component);
            ComponentsChanged?.Invoke(null, EventArgs.Empty);
        }

        public static void AddMaterial(Material mat)
        {
            materials.Add(mat);
            MaterialsChanged?.Invoke(null, EventArgs.Empty);
        }

        public static List<Component> GetComponents()
        {
            return components;
        }

        public static List<Material> GetMaterials()
        {
            return materials;
        }
        public static void RemoveComponent(Component component)
        {
            components.Remove(component);
            ComponentsChanged?.Invoke(null, EventArgs.Empty);
        }

        public static void RemoveMaterial(Material mat)
        {
            materials.Remove(mat);
            MaterialsChanged?.Invoke(null, EventArgs.Empty);
        }

        public static void SaveMaterials()
        {
            FileStream writer = new FileStream(filePath, FileMode.Create);
           // DataContractSerializer.DataContractSerialiser ser = new DataContractSerializer(typeof(List<Material>));
           // ser.WriteObject(writer, materials);
            writer.Close();
        }
    }
}
