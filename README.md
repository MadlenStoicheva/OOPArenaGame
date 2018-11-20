# OOPArenaGame
ArenaGame OOP C#


# Overview
Develop a computer game where two heroes fight each other in the arena.

# Game rules
The game goes in turns.  The two heroes fight each other in turns.  Hero 1 attacks hero 2.  If hero 2 survives the attack, he attacks back.  The game continues until one of the hero dies.
Attack mechanism
The hero who attacks unleashes pure damage, measured in points.  The hero who is being attacked can take some or all of the damage, depending on his skills.

# Specifications
All heroes have attributes:

•	Health points – when health points go zero or lower, the hero is dead.

•	Attack points

•	Armor points

When attacking, all heroes do randomly between 80% and 120% of their attack points as raw damage. 
When defending, all heroes take damage, reduced randomly with between 80% and 120% of their armor points.  The actual damage received reduces their health points.  When the health points become zero or less, the hero is dead.
There are at least two types of heroes:

# •	Warrior: 
o Nothing special about him.

# •	Knight:

o	When defending, has a 20% chance to completely block the attack and receive no damage.

o	When attacking, has a 10% chance to do 200% damage.

# •	Assassin:

o	When attacking, has a 30% chance to do 300% damage.

# •	Monk:

o	When defending, has a 30% chance to avoid the attack and receive no damage.

# • Dwarf

o When defending, has a 15% chance to completely block the attack and receive no damage.

o When attacking, has a 15% chance to do 150% damage.

# Tasks
1)	Model and implement class GameEngine, which implements the logic of the game.  The class must not implement any user interface interaction.  It must expose the necessary properties and events so that any type of user interface can be implemented with it: console app, WinForms, WPF, etc.
2)	Model and implement classes Hero, Warrior, Knight, Assassin, Monk.
3)	Write a program to test your classes.  It can be a Console, WinForms, or WPF, or even a web application.
4)	Bonus points – think of and implement additional hero classes.


