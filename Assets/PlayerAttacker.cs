using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BFM
{
  public class PlayerAttacker : MonoBehaviour
  {
    AnimatorHandler animatorHandler;

      public void Awake()
      {
        animatorHandler = GetComponentInChildren<AnimatorHandler>();
      }
      public void HandleLightAttack(WeaponItem weapon)
      {
          animatorHandler.PlayTargetAnimation(weapon.OH_Light_Attack_1, true);
      }

      public void HandleHeavyAttack(WeaponItem weapon)
      {
        animatorHandler.PlayTargetAnimation(weapon.OH_Heavy_Attack_1, true);
      }
  }
}
