using Runtime.Context.Game.Scripts.Enum;
using Runtime.Context.Game.Scripts.Model.Health;
using strange.extensions.mediation.impl;

namespace Runtime.Context.Game.Scripts.View.Enemy
{
  public class EnemyMediator : EventMediator
  {
    [Inject]
    public EnemyView view { get; set; }
    
    [Inject]
    public IHealthModel healthModel { get; set; }
    
    public override void OnRegister()
    {
      dispatcher.AddListener(GameEvent.EnemyHealthChanged, OnEnemyHealthChanged);
    }

    private void OnEnemyHealthChanged()
    {
      float enemyHealth = healthModel.GetEnemyHealth();
      view.CheckHealthForDie(enemyHealth);
    }

    public override void OnRemove()
    {
      dispatcher.RemoveListener(GameEvent.EnemyHealthChanged, OnEnemyHealthChanged);
    }
  }
}