 An Object-Oriented Football Game Model# FootballGame
 
 Footballer class 
 Fields: 
 - name (surname of the player) 
 - age (player's age) 
 - level (the skill level of a football player 
 - an integer from 0 to 100, is determined at random) 
 
 Team class 
 Fields: 
 - team_name (team name) 
 - list (list of team players) 
 - team_level (the sum of the players' levels multiplied by the coach's luck level) 
 - coach
 Method: 
 - AddFootballer (add ONE footballer to the team)
 - ListAll method (list all players on the team alphabetically, use LINQ) 
 - ListOverThirty method (display a list of all players over 30 in descending order of their skill level, use LINQ) 
 
 Game class 
 Fields: 
 - team1 (first team) 
 - team2 (second team) 
 - referee
 Method: 
 - ResultGame (to get the result of the game. If the judge condemns a team, then 40 points are added to its team skill level. 
 If it is neutral, no points are added to any team.The team that has a significantly higher team skill level wins. 
 If the lower value of the team level differs from the higher value by no more than 10% of the higher value, the result of the game will be a draw. 
 The method should output the level of team skill separately for each team and display the name of the winning team or the word "draw"). 
 - StartGame (the game has started. In this method, generate events).
 Events: 
 - foul (breaking the rules) 
 - goal   
 
 Coach class 
 Fields: 
 - name (surname of the coach) 
 - level (the level of luck is a real number from 0.5 to 1.5, is determined at random) 
 
 Referee class 
 Fields: 
 - name (surname of the judge) 
 - preference (preference of the judge: 0 - neutral, 1 - judges the first team, 2 - judges the second. Determined randomly).
