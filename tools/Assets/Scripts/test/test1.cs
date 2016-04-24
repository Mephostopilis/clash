using UnityEngine;
using System.Collections;
using SPSGame.Tools;

public class test1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        // 本打算测试下RandomName，但是此函数测试需要一个csv文件，
        // 当然制作一个csv文件是没0有任何难度的，但是不知到这个csv文件改怎么填写这个歌，所以放弃测试。
        //string path = string.Empty;
        //var rn = new RandomName(path);
        int rand = SPSRand.GetRandomNumber(10, 1000);
        Debug.Log(string.Format("{0}", rand));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
