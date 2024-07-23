using System;
using System.ComponentModel;
using Cysharp.Threading.Tasks;
using UnityEngine.SceneManagement;
using AsyncOperation = UnityEngine.AsyncOperation;


namespace Code.Infrastructure
{
    public sealed class SceneLoader
    {
        public async void LoadScene(string name, Action onLoaded = null)
        {
            AsyncOperation handle = SceneManager.LoadSceneAsync(name);
            await handle.ToUniTask();
            
            handle.completed += _ => onLoaded?.Invoke();
        }
    }
}