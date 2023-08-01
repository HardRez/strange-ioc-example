using System;
using System.Collections;
using strange.extensions.mediation.impl;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Runtime.Context.Game.Scripts.View.MainMenu
{
  public class MainMenuView : EventView
  {
    public TextMeshProUGUI enemyHealthLabel;

    public Transform playerContainer;

    private int _counter = 0;

    public void UpdateEnemyHealth(float enemyHealth)
    {
      enemyHealthLabel.text = enemyHealth.ToString();
    }

    private void Update()
    {
    }

    private void FixedUpdate()
    {
    }

    private void LateUpdate()
    {
    }

    private int _counter2 = 0;
    public void TestMethod()
    {
      while (true)
      {
        Debug.Log("TestMethod");

        _counter2++;
        
        if (_counter2 == 1000000000)
        {
          break;
        }
      }
    }
    
    public IEnumerator TestMethod2()
    {
      while (true)
      {
        Debug.Log("TestMethod");

        _counter2++;
        
        if (_counter2 == 1000000000)
        {
          break;
        }

        yield return new WaitForEndOfFrame();
        
        // yield break;
        
        Debug.Log("TestMethod");
      }
    }
    
    public IEnumerator ShowAndHideMessage()
    {
      // Show();

      yield return new WaitForSeconds(2f);
      
      // Hide();
    }

    private IEnumerator CoroutineMethod()
    {
      while (true)
      {
        Debug.Log("TestMethod - 0");

        yield return new WaitForSeconds(2f);
        
        Debug.Log("TestMethod - 1");
      }
    }

    public void OnCoroutineExampleClick()
    {
      StartCoroutine(CoroutineMethod());
      //
      //
      //
      //
      //
    }

    public void OnCreateObjectClick()
    {
      AsyncOperationHandle<GameObject> asyncOperation = Addressables.InstantiateAsync("PlayerObject", playerContainer);
      asyncOperation.Completed += OnCreateObjectCompleted;
    }

    private void OnCreateObjectCompleted(AsyncOperationHandle<GameObject> obj)
    {
      obj.Result.name = $"PlayerObject_{_counter++}";
    }

    // protected override void Awake()
    // {
    //   base.Awake();
    //   
    //   // Debug.Log("MainMenuView> Awake");
    // }
    //
    // protected override void Start()
    // {
    //   base.Start();
    //   
    //   // Debug.Log("MainMenuView> Start");
    // }
    //
    // public void OnButtonClicked()
    // {
    //   // Debug.Log("MainMenuView> OnButtonClicked");
    //   dispatcher.Dispatch(MainMenuEvent.Clicked);
    // }

    // private void OnEnable()
    // {
    //   // Debug.Log("MainMenuView> OnEnable");
    // }
    //
    // private void OnDisable()
    // {
    //   // Debug.Log("MainMenuView> OnDisable");
    // }
    //
    // protected override void OnDestroy()
    // {
    //   base.OnDestroy();
    //   
    //   // Debug.Log("MainMenuView> OnDestroy");
    // }
  }
}