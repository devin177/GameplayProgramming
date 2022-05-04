using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cowtech
{
    public class VegetableMaker : MonoBehaviour
    {
        [SerializeField] private GameObject cucumber;
        [SerializeField] private GameObject garlic;
        [SerializeField] private GameObject onion;
        [SerializeField] private GameObject zucchini;

        [SerializeField] private Vector3 factoryPosition;

        public void Make()
        {
            // Generate a random number of veggies.
            var numVeggies = Random.Range(1,11);
            for (int i = 0; i < numVeggies; i++)
            {
                var fruitType = Random.Range(1, 5);
                switch (fruitType)
                {
                    case 1:
                        GameObject newCucumber = Instantiate(this.cucumber, factoryPosition, Quaternion.identity);
                        Destroy(newCucumber, 5.0f);
                        break;
                    case 2:
                        GameObject newGarlic = Instantiate(this.garlic, factoryPosition, Quaternion.identity);
                        Destroy(newGarlic, 5.0f);
                        break;
                    case 3:
                        GameObject newOnion = Instantiate(this.onion, factoryPosition, Quaternion.identity);
                        Destroy(newOnion, 5.0f);
                        break;
                    case 4:
                        GameObject newZucchini = Instantiate(this.zucchini, factoryPosition, Quaternion.identity);
                        Destroy(newZucchini, 5.0f);
                        break;
                }
            }
        }
    }
}