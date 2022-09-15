using System.Collections;
using Edsm.Sdk.Dto;
using Edsm.Sdk.Model.Edsm.Types;
using Edsm.Sdk.Model.Types.Stars;

namespace Edsm.Sdk.Model.Edsm.Systems.System
{
    public class CubeSystemsResponse : IEdsmResponse, IList<CubeSystemsResponseItem>
    {
        public readonly List<CubeSystemsResponseItem>? cubeSystemsResponseItems;

        public CubeSystemsResponse()
        {
            cubeSystemsResponseItems = new List<CubeSystemsResponseItem>();
        }

        public CubeSystemsResponseItem this[int index] { get => cubeSystemsResponseItems[index]; set => cubeSystemsResponseItems[index] = value; }

        public int Count => cubeSystemsResponseItems.Count;

        public bool IsReadOnly => false;

        public void Add(CubeSystemsResponseItem item)
        {
            cubeSystemsResponseItems.Add(item);
        }

        public void Clear()
        {
            cubeSystemsResponseItems.Clear();
        }

        public bool Contains(CubeSystemsResponseItem item)
        {
            return cubeSystemsResponseItems.Contains(item);
        }

        public void CopyTo(CubeSystemsResponseItem[] array, int arrayIndex)
        {
            cubeSystemsResponseItems.CopyTo(array, arrayIndex);
        }

        public IEnumerator<CubeSystemsResponseItem> GetEnumerator()
        {
            return cubeSystemsResponseItems.GetEnumerator();
        }

        public int IndexOf(CubeSystemsResponseItem item)
        {
            return cubeSystemsResponseItems.IndexOf(item);
        }

        public void Insert(int index, CubeSystemsResponseItem item)
        {
            cubeSystemsResponseItems.Insert(index, item);
        }

        public bool Remove(CubeSystemsResponseItem item)
        {
            return cubeSystemsResponseItems.Remove(item);
        }

        public void RemoveAt(int index)
        {
            cubeSystemsResponseItems.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return cubeSystemsResponseItems.GetEnumerator();
        }
    }

    public class CubeSystemsResponseItem
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

        public CubeSystemsResponseItem(
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
