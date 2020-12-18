using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class phrase_bank : MonoBehaviour
{
    public Text text_component;

    public float text_update_time = 5;

    private string[] goblin_names = {
        "Skeevy Wallace",
        "Skeevy Williamina",
        "Skeevy \"Dirty\" Harry",
        "Unclean Frank",
        "Gyncs \"The Fuzz\" Zelk",
        "Normal Ted",
        "Unremarkable Jim",
        "Skeevy Fortbakt",
        "Greenskin Gristle",
        "Dirking Dirk",
        "Skeevy Max",
        "Skeevy Imogen",
        "Skeevy Tim",
        "Skeevy Ellie",
        "Skeevy Neil",
        "Skeevy Ruth",
        "Skeevy Pupper",
        "Soulless Johnny",
        "Skeevy Bartholemew",
        "Toadying Tom",
    };

    private string[] goblin_phrases = {
        "Click me, daddy!",
        "Help! I'm not really a goblin! An evil witch cast a spell on me!",
        "Don't stew me, Daddy!",
        "I'm tasty and nutritious!",
        "Chase me! Chase me!",
        "Catch me if you can!",
        "It's my dream to be cooked and eaten by my Daddy!",
        "You're not my real dad!",
        "It's my turn! It's my turn!",
        "Stop shoving!",
        "Now is the winter of our discontent.",
        "Why am I running?",
        "I can't stop running!",
        "How many of us must perish until you are satisfied?",
    };

    private float update_timer;

    // Start is called before the first frame update
    void Start()
    {
        update_timer = text_update_time;
    }

    // Update is called once per frame
    void Update()
    {
        update_timer -= Time.deltaTime;
        if (update_timer <= 0) {
            update_timer = text_update_time;

            var goblin_name = goblin_names[Random.Range(0, goblin_names.Length)];
            var goblin_phrase = goblin_phrases[Random.Range(0, goblin_phrases.Length)];
            text_component.text = goblin_name + " says: " + goblin_phrase;
        }
    }
}
