using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class phrase_bank : MonoBehaviour
{
    public Text text_component;

    public float text_update_time = 5;

    public AudioSource audioSource;

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
        "Harold the Hobgoblin",
        "Mummy Goblin",
        "Sordid Sid",
        "Unpleasant Alex",
        "Squalid Bruce",
        "Skeevy Albert Einstein",
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
        "Abscond after me, father!",
        "Chase me Daddy!",
        "[ACHIEVEMENT UNLOCKED: READ THIS MESSAGE]",
        "Tee-hee!",
        "I'm a naughty gobbo!",
        "Catch me, art father who are Max!",
        "Stew me! Stew me!",
        "I go well with carrots and onions.",
        "Don't tread on me!",
        "Jet fuel can't melt steel beams!",
        "I am a just a little greenskin.",
        "I'M RUNNING WITH KNIVES!",
        "What's the point of this game?",
        "New high score!",
        "Don't make me run I am full of chocolate!",
        "We are legion!",
        "You stewed my family!",
        "I make a very satisfying splash noise.",
        "All hail the goblin king!",
        "Daddy! Daddy! Over here!"
    };

    private float update_timer;

    // Start is called before the first frame update
    void Start()
    {
        audioSource.Play();
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
