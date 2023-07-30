using Runtime.Context.Game.Scripts.Enum;
using Runtime.Context.Game.Scripts.Model.Health;
using strange.extensions.mediation.impl;
using UnityEngine;

namespace Runtime.Context.Game.Scripts.View.MainMenu
{
  public enum MainMenuEvent
  {
    Clicked
  }

  public class MainMenuMediator : EventMediator
  {
    [Inject]
    public MainMenuView view { get; set; }
    
    [Inject]
    public IHealthModel healthModel { get; set; }
    
    public override void OnRegister()
    {
      // Debug.LogError("MainMenuMediator> OnRegister");
      
      view.dispatcher.AddListener(MainMenuEvent.Clicked, OnClicked);
      
      dispatcher.AddListener(GameEvent.EnemyHealthChanged, OnEnemyHealthChanged);

      Load();
    }

    private void Load()
    {
      UpdateEnemyHealth();
    }

    private void OnEnemyHealthChanged()
    {
      UpdateEnemyHealth();
    }
    
    private void UpdateEnemyHealth()
    {
      float enemyHealth = healthModel.GetEnemyHealth();
      view.UpdateEnemyHealth(enemyHealth);
    }

    private void OnClicked()
    {
      // Debug.LogError("MainMenuMediator> OnClicked");
    }

    public override void OnRemove()
    {
      // Debug.LogError("MainMenuMediator> OnRemove");
      
      view.dispatcher.RemoveListener(MainMenuEvent.Clicked, OnClicked);
      dispatcher.RemoveListener(GameEvent.EnemyHealthChanged, OnEnemyHealthChanged);
    }
  }
}