using Edsm.Sdk.Dto;
using Edsm.Sdk.Model.Edsm.Types;
using Edsm.Sdk.Model.Types.Stars;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Edsm.Sdk.Model.Types.Stars.Star;

namespace Edsm.Sdk.Model.Edsm.Systems.System
{
    public class SphereSystemsResponse : IEdsmResponse, IList<SphereSystemsResponseItem>
    {
        public readonly List<SphereSystemsResponseItem>? sphereSystemsResponseItems;

        public SphereSystemsResponse()
        {
            sphereSystemsResponseItems = new List<SphereSystemsResponseItem>();
        }

        public SphereSystemsResponseItem this[int index] { get => sphereSystemsResponseItems[index]; set => sphereSystemsResponseItems[index] = value; }

        public int Count => sphereSystemsResponseItems.Count;

        public bool IsReadOnly => false;

        public void Add(SphereSystemsResponseItem item)
        {
            sphereSystemsResponseItems.Add(item);
        }

        public void Clear()
        {
            sphereSystemsResponseItems.Clear();
        }

        public bool Contains(SphereSystemsResponseItem item)
        {
            return sphereSystemsResponseItems.Contains(item);
        }

        public void CopyTo(SphereSystemsResponseItem[] array, int arrayIndex)
        {
            sphereSystemsResponseItems.CopyTo(array, arrayIndex);
        }

        public IEnumerator<SphereSystemsResponseItem> GetEnumerator()
        {
            return sphereSystemsResponseItems.GetEnumerator();
        }

        public int IndexOf(SphereSystemsResponseItem item)
        {
            return sphereSystemsResponseItems.IndexOf(item);
        }

        public void Insert(int index, SphereSystemsResponseItem item)
        {
            sphereSystemsResponseItems.Insert(index, item);
        }

        public bool Remove(SphereSystemsResponseItem item)
        {
            return sphereSystemsResponseItems.Remove(item);
        }

        public void RemoveAt(int index)
        {
            sphereSystemsResponseItems.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return sphereSystemsResponseItems.GetEnumerator();
        }
    }

    public class SphereSystemsResponseItem
    {
        public readonly float distance;
        public readonly int? bodyCount;
        public readonly string name;
        public readonly int id;
        public readonly long? id64;
        public readonly Coords coords;
        public readonly bool coordsLocked;
        public readonly bool requirePermit;
        public readonly string permitName;
        public readonly Information information;
        public readonly StarShort primaryStar;

        public SphereSystemsResponseItem(
            float distance,
            int? bodyCount,
            string name,
            int id,
            long? id64,
            Coords coords,
            bool coordsLocked,
            bool requirePermit,
            string permitName,
            Information information,
            StarShort primaryStar)
        {
            this.distance = distance;
            this.bodyCount = bodyCount;
            this.name = name;
            this.id = id;
            this.id64 = id64;
            this.coords = coords;
            this.coordsLocked = coordsLocked;
            this.requirePermit = requirePermit;
            this.permitName = permitName;
            this.information = information;
            this.primaryStar = primaryStar;
        }
    }
}
