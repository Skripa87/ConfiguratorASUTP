using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConfiguratorASUTP.Models
{
    public static class ASUTPConfiguratorManager
    {
        private static ASUTPConfiguratorContext db;
        private static List<Part> parts;
        private static List<RemoteControl> remoteControls;
        
        static ASUTPConfiguratorManager()
        {
            db = new ASUTPConfiguratorContext();
            parts = new List<Part>();
            remoteControls = new List<RemoteControl>();
            foreach (Part item in db.Parts)
            {
                parts.Add(item);
            }
            foreach (var item in remoteControls)
            {
                remoteControls.Add(item);
            }
        }
        public static List<Part> getParts() { return parts; }
        public static List<RemoteControl> getRemoteControls() { return remoteControls; }

    }
}