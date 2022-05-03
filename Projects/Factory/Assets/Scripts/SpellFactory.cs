using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arcanum
{
    public enum Spells { Boomerang, Rain, Vegetable }

    [RequireComponent(typeof(VegetableMaker))]
    [RequireComponent(typeof(RainMaker))]
    [RequireComponent(typeof(BoomerangMaker))]
    public class SpellFactory : MonoBehaviour
    {
        public void BuildSpell(Spells type)
        { 
            if (Spells.Boomerang == type)
            {
                var boomerang = this.GetComponent<BoomerangMaker>().Make();
                boomerang.transform.position = this.transform.position;
            }
            else if (Spells.Rain == type)
            {
                var rain = this.GetComponent<RainMaker>().Make();
                // rain.transform.position = this.transform.position;
                rain.transform.position = GameObject.Find("Ground").transform.position;
            }
            else if (Spells.Vegetable == type)
            {
                this.GetComponent<VegetableMaker>().Make();
            }
        }

        public void Update()
        {
            if (Input.GetButtonDown("Jump"))
            {
                this.BuildSpell(Spells.Boomerang);
            }
            else if(Input.GetButtonDown("Fire1"))
            {
                this.BuildSpell(Spells.Rain);
            }
            else if (Input.GetButtonDown("Fire2"))
            {
                this.BuildSpell(Spells.Vegetable);
            }
         }

    }

}
