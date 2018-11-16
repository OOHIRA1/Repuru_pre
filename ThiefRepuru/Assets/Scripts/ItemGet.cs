using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGet : MonoBehaviour {
    [SerializeField] GameObject ItemDetails = null;　//Itemの詳細

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //アイテム詳細の表示をする関数--------------------
    public void ItemDisplay( bool ItemValue ) {
        ItemDetails.SetActive( ItemValue );
    }
    //------------------------------------------------

}
