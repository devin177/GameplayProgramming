using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cowtech
{
    public class BoomerangMaker : MonoBehaviour, IFactorySpell
    {
        [SerializeField] private GameObject prefab;

        public void Start()
        {
        }

        public GameObject Make()
        {
            GameObject newGameObject = Instantiate(this.prefab, new Vector3(0,0,0), Quaternion.identity);
            Destroy(newGameObject, 5.0f);
            return newGameObject;
        }
    }
}
