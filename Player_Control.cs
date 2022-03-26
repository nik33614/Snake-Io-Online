using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player_Control : MonoBehaviour
{
    float posit = 2.5f;
    int name = 5;
    public GameObject Spawn;
    private GameObject obj;
    public int Player = 1;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Food")
        {
            StartCoroutine(Create());//отправка на сервер запрос на создание_ждем ответа-ответ получен-кижает координаты
        }
    }

     private IEnumerator Create()
    {
        //WWWForm form = new WWWForm();
        //form.AddField("Player", Player);

        //WWW www = new WWW("http://doublenikmak.ru/Cpu.php", form);
        //yield return www;
        //if (www.error != null)
        //{
        //    Debug.Log("Error: " + www.error);
        //    yield break;
        //}
        //else
        float x = 0;
        x+=0.001f;
        float y = 0;
        y+=0.001f;
        int num = 6;
        string answer = x.ToString()+"_"+y.ToString()+"_"+num.ToString()+"_";
        //{
        //    if(www.text != "false")
        //    {
                string[] sub;
                //string answer = www.text;
                sub = answer.Split('_');//x_y_num_
                CreateMore(float.Parse(sub[0]),float.Parse(sub[1]),Convert.ToInt32(sub[2]));
        //    }
            yield break;
        //}
    }
    void Start()
    {
        
    }
    void Update()
    {
        //transform.Translate(new Vector2(Speed * Time.deltaTime, 0.5f * Time.deltaTime));//move towards with speed

        //transform.position = Vector3.Lerp(_startPos, _endPos, Time.time);//move to the object
    }
    void CreateMore(float x, float y, int num)
    {
        Vector3 pos = new Vector3(x, y, 0);//по полученным координатам
        obj = Instantiate(Spawn, pos, Quaternion.identity);
        
        string new_name = "Player"+ Player.ToString()+"_"+num.ToString();//создание имени

        obj.name = new_name;

        obj.GetComponent<Children>().children = num;//изменить в скрипте номер player
        obj.GetComponent<Children>().Player = Player;
    }
}