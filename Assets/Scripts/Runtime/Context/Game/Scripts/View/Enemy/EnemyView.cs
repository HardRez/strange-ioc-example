using strange.extensions.mediation.impl;
using UnityEngine;

namespace Runtime.Context.Game.Scripts.View.Enemy
{
  public class EnemyView : EventView
  {
    public void CheckHealthForDie(float health)
    {
      if (health == 0)
      {
        Object.Destroy(gameObject);
      }
    }
  }
}