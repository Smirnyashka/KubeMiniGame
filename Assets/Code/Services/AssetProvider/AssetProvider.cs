using UnityEngine;

namespace Code.Services.AssetProvider
{
    public class AssetProvider
    {
        public GameObject Instantiate(string path, Vector2 at)
        {
            var prefab = Resources.Load<GameObject>(path);
            return Object.Instantiate(prefab, at, Quaternion.identity);
        }
    }
}