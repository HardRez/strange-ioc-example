using Runtime.Context.Game.Scripts.Command;
using Runtime.Context.Game.Scripts.Model.Health;
using Runtime.Context.Game.Scripts.View.Enemy;
using Runtime.Context.Game.Scripts.View.MainMenu;
using Runtime.Context.Game.Scripts.View.Player;
using strange.extensions.context.api;
using strange.extensions.context.impl;
using UnityEngine;

namespace Runtime.Context.Game.Scripts.Config
{
  public class GameContext : MVCSContext
  {
    public GameContext(MonoBehaviour view) : base(view)
    {
    }
    
    public GameContext(MonoBehaviour view, ContextStartupFlags flags) : base(view, flags)
    {
    }
    
    protected override void mapBindings()
    {
      base.mapBindings();

      injectionBinder.Bind<IHealthModel>().To<HealthModel>().ToSingleton();

      mediationBinder.Bind<MainMenuView>().To<MainMenuMediator>();
      mediationBinder.Bind<PlayerView>().To<PlayerMediator>();
      mediationBinder.Bind<EnemyView>().To<EnemyMediator>();

      commandBinder.Bind(ContextEvent.START).To<InitGameCommand>();
    }
  }
}