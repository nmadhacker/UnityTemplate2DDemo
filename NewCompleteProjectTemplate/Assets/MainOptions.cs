using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainOptions : MonoBehaviour {

	// Use this for initialization
	void Start () {

#if UNITY_ANDROID
#if DEBUG_ONLY
        int numero = 10;
#endif
#else
        int numero = 5;
#endif
    }
}
