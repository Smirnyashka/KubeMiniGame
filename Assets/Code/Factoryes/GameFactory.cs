using UnityEngine;

namespace Code.Factoryes
{
    public class GameFactory
    {

        private const string BlackKubePath = "Assets/Prefabs/BlackKube.prefab";
        private const string RedKubePath = "Assets/Prefabs/RedKube.prefab";

        private Vector2 _spawnPosition = new Vector2(Random.Range(0, 5), Random.Range(0, 5));
        
        private void Load()
        {
            
        }
        
        private GameObject CreateEnemy()
        {
            return Instantiate(BlackKubePath, _spawnPosition);
        }

        private GameObject Instantiate(string path, Vector2 at)
        {
            var prefab = Resources.Load<GameObject>(path);
            return Object.Instantiate(prefab, at, Quaternion.identity);
        }
    }
}