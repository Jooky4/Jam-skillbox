using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptMenu : MonoBehaviour
{
    public void onCklickStartGame() // Запуск игры
    {
        Application.LoadLevel(name: "MainScene"); // Запуск игровой сцены
    }

    public void onCklickExitGame() // Выход из игры при нажатии кнопки в меню
    {
        Application.Quit();  // Закрыть приложение
    }

    void Update() // Завершает работу приложения при нажатии на кнопку Esc
    {
        if (Input.GetKey("escape")) // если нажата кнопка Esc (Escape)
        {
            Application.Quit();  // Закрыть приложение
        }
    }
}