using Code.Infrastructure;
using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    private GameStateMachine _gameStateMachine;

    private void Awake()
    {
        _gameStateMachine = new GameStateMachine(new SceneLoader());
        _gameStateMachine.Enter<LoadingState>();
    }
}
