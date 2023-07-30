using Runtime.Context.Game.Scripts.Enum;
using strange.extensions.context.api;
using strange.extensions.dispatcher.eventdispatcher.api;

namespace Runtime.Context.Game.Scripts.Model.Health
{
  public class HealthModel : IHealthModel
  {
    [Inject(ContextKeys.CONTEXT_DISPATCHER)]
    public IEventDispatcher dispatcher{ get; set;}
    
    private float _enemyHealth = 100;
    public void HitEnemy()
    {
      _enemyHealth -= 10;
      dispatcher.Dispatch(GameEvent.EnemyHealthChanged);
    }
    
    public float GetEnemyHealth()
    {
      return _enemyHealth;
    }
  }
}