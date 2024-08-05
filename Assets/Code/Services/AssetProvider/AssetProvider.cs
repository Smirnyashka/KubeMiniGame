using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Code.Services.AssetProvider
{
    public class AssetProvider
    {
        private Dictionary<string, AsyncOperationHandle> _completed = new();
        
        public GameObject Instantiate(string path)
        {
            var prefab = Resources.LoadAsync<GameObject>(path);
            return Object.Instantiate(prefab);
        }
    }
}