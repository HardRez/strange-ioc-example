using strange.extensions.mediation.impl;
using UnityEngine;

namespace Runtime.Context.Game.Scripts.View.Player
{
  public class PlayerView : EventView
  {
    public void OnFire()
    {
      Debug.Log("PlayerView> OnFire");
      dispatcher.Dispatch(PlayerEvent.Fire);
    }
  }
}