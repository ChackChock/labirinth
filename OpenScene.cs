using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenScene : MonoBehaviour
{
    public int id; // Переменная для номера сцена
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Загрузка сцены с номером из переменной id
        SceneManager.LoadScene(id); 
    }
}
