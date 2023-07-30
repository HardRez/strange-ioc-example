using System;
using strange.extensions.mediation.impl;
using TMPro;
using UnityEngine;

namespace Runtime.Context.Game.Scripts.View.MainMenu
{
  public class MainMenuView : EventView
  {
    public TextMeshProUGUI enemyHealthLabel;

    public void UpdateEnemyHealth(float enemyHealth)
    {
      // enemyHealthLabel.text = enemyHealth.ToString();
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