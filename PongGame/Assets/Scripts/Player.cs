using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    float max_Y = 3.60f, min_Y = -3.60f;

    Vector2 startPosP1 = new Vector2(-8f, 3.1f);

    // Start is called before the first frame update
    void Start()
    {
        transform.position = startPosP1;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movimentacao();
        Limite();        
    }

    void Movimentacao()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector2(0, speed * Time.deltaTime));
        }

        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector2(0, -speed * Time.deltaTime));
        }

    }

    void Limite()
    {
        // Criando variável temporária pegando a posição do player
        Vector2 temp = transform.position;

        if(temp.y < min_Y)
        {
            temp.y = min_Y;
        }

        if (temp.y > max_Y)
        {
            temp.y = max_Y;
        }

        // Atualizando a posição para a nova variável
        transform.position = temp;
    }
}
