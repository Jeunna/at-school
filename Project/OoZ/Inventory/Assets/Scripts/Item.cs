﻿//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Item : MonoBehaviour
//{
//    public enum TYPE { HP, MP }

//    public TYPE type;           // 아이템의 타입.
//    public Sprite DefaultImg;   // 기본 이미지.
//    public int MaxCount;        // 겹칠수 있는 최대 숫자.  

//    // 인벤토리에 접근하기 위한 변수.
//    private Inventory Iv;

//    void Awake()
//    {
//        // 태그명이 "Inventory"인 객체의 GameObject를 반환한다.
//        // 반환된 객체가 가지고 있는 스크립트를 GetComponent를 통해 가져온다.
//        Iv = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>();

//    }

//    void AddItem()
//    {
//        // 아이템 획득에 실패할 경우.
//        if (!Iv.AddItem(this))
//            Debug.Log("아이템이 가득 찼습니다.");
//        else // 아이템 획득에 성공할 경우.
//            gameObject.SetActive(false); // 아이템을 비활성화 시켜준다.
//    }

//    // 충돌체크
//    void OnTriggerEnter(Collider _col)
//    {
//        // 플레이어와 충돌하면.
//        if (_col.gameObject.layer == 10)
//            AddItem();
//    }
//}