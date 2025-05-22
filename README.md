# 🧠 Learn English Words Game for Kids

This is a C# WinForms educational game developed to help children (especially Arabic-speaking) learn English vocabulary in a fun and interactive way. The game displays a random Arabic word and prompts the user to type the English translation. 

If the user gets the word right, the score increases. If wrong, the word is recorded and shown again later for reinforcement. The app also tracks wrong attempts, completions, and overall progress percentage.

## 🎯 Features

- ✅ Random Arabic word display
- ✍️ User inputs English translation
- 📈 Tracks score, wrong answers, and completion rounds
- 📂 Stores words in `words.json` and mistakes in `wrong.json`
- 🧠 Repeats incorrect words until mastered
- 🧑‍🏫 Admin panel to add, update, or remove vocabulary words

## 📸 Screenshots
![Game UI](https://github.com/StevenTharwat/Learn-English-Words-Game-for-Kids/blob/main/Images/1.png)
![Game UI](https://github.com/StevenTharwat/Learn-English-Words-Game-for-Kids/blob/main/Images/2.png)
![Game UI](https://github.com/StevenTharwat/Learn-English-Words-Game-for-Kids/blob/main/Images/3.png)
## 🔧 How It Works

1. The app loads all Arabic-English word pairs from `words.json`.
2. Displays a random Arabic word and waits for English input.
3. On correct answer: score increments, word is removed from the list.
4. On wrong answer: score decrements, word is stored in `wrong.json`, and shown again later.
5. Once all words are completed, the round counter increments and resets.

## 🧩 Future Ideas
1. Audio pronunciation
2. Score history tracking
3. Export wrong words for printing
4. Difficulty levels

👨‍💻 Developed By
Steven Tharwat

