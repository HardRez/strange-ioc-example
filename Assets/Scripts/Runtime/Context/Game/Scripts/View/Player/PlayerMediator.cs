using Runtime.Context.Game.Scripts.Enum;
using Runtime.Context.Game.Scripts.Model.Health;
using strange.extensions.mediation.impl;
using UnityEngine;

namespace Runtime.Context.Game.Scripts.View.Player
{
  public enum PlayerEvent
  {
    Fire
  }
  public class PlayerMediator : EventMediator
  {
    [Inject]
    public PlayerView view { get; set; }
    
    [Inject]
    public IHealthModel healthModel { get; set; }
    
    public override void OnRegister()
    {
      view.dispatcher.AddListener(PlayerEvent.Fire, OnFire);
    }

    private void OnFire()
    {
      Debug.Log("PlayerMediator> OnFire");
      healthModel.HitEnemy();
    }

    public override void OnRemove()
    {
      view.dispatcher.RemoveListener(PlayerEvent.Fire, OnFire);
    }
  }
}