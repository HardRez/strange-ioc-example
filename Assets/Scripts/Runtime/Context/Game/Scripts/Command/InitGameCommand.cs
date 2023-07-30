using strange.extensions.command.impl;
using UnityEngine;

namespace Runtime.Context.Game.Scripts.Command
{
  public class InitGameCommand : EventCommand
  {
    public override void Execute()
    {
      // Debug.Log("Game context ready");
      // Debug.LogWarning("Game context ready");
      // Debug.LogError("Game context ready");
    }
  }
}