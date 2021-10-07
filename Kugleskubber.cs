using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Digiteknik {

    public class Kugleskubber : MonoBehaviour
    {
        SceneInputs handlinger;

        Vector2 skub;
        
        void Awake()
        {
            handlinger = new SceneInputs();

            handlinger.Gameplay.Grow.performed += ctx => Grow();

            handlinger.Gameplay.SkubBold.performed += ctx => skub = ctx.ReadValue<Vector2>();
            handlinger.Gameplay.SkubBold.canceled += ctx => skub = Vector2.zero;
        }

        void OnEnable() {
            handlinger.Gameplay.Enable();
        }

        void OnDisable() {
            handlinger.Gameplay.Disable();
        }

        void Grow() {
            transform.localScale *= 1.1f;
        }

        // Update is called once per frame
        void Update()
        {
            Vector3 tip = new Vector3(skub.x, 0, skub.y) * 0.5f;
            gameObject.GetComponent<Rigidbody>().velocity += tip;
        }
    }
}