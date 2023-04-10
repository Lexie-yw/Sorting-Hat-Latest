# Sorting-Hat
## Project Overview	
Sorting Hat is a quiz game that sorts the user into one of the four houses at Hogwarts. Time to explore the magic!

The game currently supports 7 languages:  English, Simplified Chinese, French, German, Spanish, Japanese, and Italian.

## Team Members: 
The Sorting Hat game was created and localized by three grad students (see below table) at MIIS. 

|Ellie (Zhiqing) Wu|Lexie (Yiwen) Wang|Maud Grasmenil||
|:--:|:--:|:--:|:--:|
|Design, Localization|Engineering, Localization Project Management|I18n Engineering, Localization||
|zhiqingw@middlebury.edu, zhiqingwu1998@gmail.com |yw2@middlebury.edu, lexieyww@gmail.com|mgrasmenil@middlebury.edu, maud.grasmenil@gmail.com||

<!---
Note: This project is the final course project for Software Internationalization and Localization, taught by Professor David Mohr (dmohr@middlebury.edu).
Test case:2 This is to test how if I change the code, would there be any changes reflected on GitLocalize
-->
[names listed follow the alphabetical order]

## Introduction
### Project Ideation
Sorting Hat is a C# game inspired by the Harry Potter films and the quiz game mechanism. There are 11 multiple-choice questions in the game. Based on the user's answers to the questions, the Sorting Hat sorts the user into one of the four houses at Hogwarts.

### Game Background
Hogwarts School of Witchcraft and Wizardry has four houses: Gryffindor, Slytherin, Ravenclaw, and Hufflepuff. Each founder of the house had a different view of what makes good witchcraft and wizardry, so the admission requirements for the houses were different. New students admitted to Hogwarts have to take the Sorting Hat test to know which house they will be sorted into.

### Game Rules
There will be 11 multiple-choice questions, testing users on their interests, hobbies, characters, etc. Based on their answers, a result will be generated through calculation, telling the user which house they will enter.

### External Resource Referenced
- Development Related: https://www.mooict.com/c-tutorial-create-a-simple-multiple-choice-quiz-game-in-visual-studio/
- Content Related: https://harrypotter.fandom.com/wiki/Harry_Potter
- Image Assets: https://unsplash.com/

## Product Development 
[Engineering: Game Source Code]:
Generally, a quiz only has one result, the correct rate (External Resource Referenced). However, in our quiz game, based on users’ answers, they will be assigned one result from four possible results. To implement this, the code logic is indicated below:

Each question has four choices, and each choice is related to a house at Hogwarts. We assign each choice with a label (Gryffindor, Slytherin, Ravenclaw, and Hufflepuff). Then when we store the answer to an array, we do not store the actual string of choice, we store the label. After the user completes the quiz, we will calculate which label (house) in the array has the highest frequency, then we can assign the user to that house.
<!---
<div>
  <img src="./README assets/Code example.png">
  <p>Code example: storing the label into an array.</p>
  <img src="./README assets/Non-localized product1.png" width="450" 
     height="400">
  <img src="./README assets/Non-localized product1.png" width="450" 
     height="400">
  <p>The completed non-localized project.</p>
  <img src="./README assets/Code example.png">
</div>
-->

## Project Management
### Work Log:
There are mainly four development stages: Ideation, Game Development [Source Code], Internationalization, and Localization. We created a product development plan [Progress Tracker] to follow and met five times either in person or online to complete the project. 
<div>
  <img src="./README assets/Product development plan.png" height="500" width="500"> 
  <img src="./README assets/worklog.png" height="300" width="300">
  <p>Product development plan and work log.</p>
</div>

### Localization File Management:
Good management of assets is a must for successful localization. Sorting Hat has three types of assets regarding localization: Media, Source Text, and Translations. To make sure those assets are well organized and easily accessible, they were well categorized and put into three different folders on Google Drive. 
<div>
  <img src="./README assets/Drive folder structure.png" height="500" width="500">
  <img src="./README assets/Media folder.png" height="300" width="300">
  <p>Google Drive folder structure and assets under Media folder.</p>
</div>

### Tools:
To ensure smooth collaboration between product, engineering, and the localization team, we used Visual Studio Community & GitHub for code development, Google drive for general file management, Whatsapp for progress updates and debugging chat, and Zoom for online meetings.
<div>
  <img src="README assets/Git Repo.png">
  <p>GitHub repository for the Sorting Hat game.</p>
</div>

## Internationalization
Localization starts at the earliest stage of a game’s development. In that regard, the .NET framework made app internationalization rather easy. Once the windows form was properly internationalized, we only had to add text in the different resource files.
### Engineering
1) We created a language switcher: with a list of the different languages. To the Dropdown list, a function is assigned that first gets the cultural info of the selected locale (Switch/case), applies it (CurrentCulture & CurrentUICulture), then clears and reinitializes the form. The CultureInfo object allowed us to adapt some cultural elements to the target locale, such as the date format used in the final text.
<div>
  <img src="README assets/Language Switcher.png">
  <p>Code example: language switcher.</p>
</div>


2) Internationalization can be done in the Form properties (Designer.cs, “Localizable”: True). Switching from default to the different locales automatically creates new resource files for each locale, in which we can put the variables and their corresponding strings.

3) String externalization was then implemented in the code by creating variables instead of strings (getting attributed strings in resource files) and avoiding concatenation. 
<div>
  <img src="README assets/Externalized Strings.png">
  <p>Externalized strings in the en-US resource file.</p>
</div>

### Design internationalization 
Other elements had to be taken into consideration in the internationalization process. 
Text size: The size of the text had to be adapted for each locale to ensure its readability (Chinese characters smaller, for instance).
Box size: Similarly, once strings were translated, we realized that some questions were too long in certain locales, overflowing the textbox (the extra text would not display). We therefore adapted the size of the text boxes when needed. In the future, it would be better to make the boxes automatically resizable so they can adapt to the length of their content.
Layout: some layout issues occurred for some locales: the position of the language label changes in the French (France). Correcting it would reinitialize our resource files, therefore, due to time constraints, it hasn’t been done yet. This showed us that design had to be finalized before adding the strings in the resource files. Another solution we would like to explore is to create resource files for externalized strings that would be independent from the Form.cs file.
Language:
Encoding: we wanted to ensure that all of the languages would be properly encoded and that others could be indeed later on. We, therefore, used the Unicode standard.
Font: we had to ensure that they would work for all languages (esp. Chinese and Japanese characters). An idea was to use different fonts for Latin script and Chinese and Japanese script.

## Design
### General UI design
Following the theme of the sorting hat, the basic concept of our UI design mirrors the overall aesthetics of the Harry Potter movies, as well as other spinoffs of the franchise. More specifically, we aimed to replicate the sorting hat quiz offered on the Pottermore website, which evaluates the users’ answers in a set of short multiple-choice questions relating to the Harry Potter series. 

In an attempt to recreate the medieval gothic architectural style of the setting of the original story, Hogwarts School of Witchcraft and Wizardry, we chose a dark color scheme for the UI, paired with a crinkled, sepia-colored paper texture in the background. 

One challenge in the design process is to choose the proper colors for the answer choice buttons. As mentioned previously, the four houses each possess an individual representative color, red, yellow, blue, and green, respectively. To avoid using the same color as any one of the houses, we built the buttons with black backgrounds and orange text, solving the problem while retaining the medieval style and increasing legibility.

### Font Selection
Building upon the previous section, another aspect in the general UI design process of this game involves finding a font that further highlights the style. In this case, the font for the Latin-script alphabet that we chose after careful consideration is Xéfora, which is modeled after the font style of Harry Potter movie posters. As mentioned earlier, we adopted the Unicode standard to include the characters needed for the languages that we localized into. So, another criterion for font selection for us was to choose one that contains all characters needed, along with essential accent marks for Spanish, French, and German. On the other hand, as for the two CCJK, or C(hinese) J(apanese) languages we chose, we encountered similar problems when selecting fonts. Though one font named Oriental was shortlisted for Japanese, it only supports one out of three Japanese writing systems. Therefore, we decided to leave the Chinese and Japanese versions of our game in the default font.
<div>
  <img src="README assets/German UI.png" width="500" 
     height="350">
  <img src="README assets/Spanish UI.png" width="500" 
     height="350">
  <p>The Sorting Hat game UI localized into German and Spanish.</p>
</div>

Circling back to the chosen font, although it works for all of the non-CCJK versions of our game, the font is yet to be embedded, meaning that it only shows when the operating system has Xéfora installed. A demo of the game with the stylized font is shown below.

Another problem, and perhaps the most critical one, that we encountered during font implementation was the limitation of Visual Studio with font types. First of all, Visual Studio only supports TrueType fonts (TTF), so OpenType fonts are to be avoided for similar projects in the future.

## Localization
For localization, the challenge that was apparent throughout the process is foreignization versus domestication.

The goal of our final deliverable is to, again, emulate the style of the original Pottermore quiz. Therefore, many concepts unique to the UK were introduced in the questions. One example of such is a question regarding teatime snacks. It is common knowledge that people from the UK often enjoy tea with a variety of sweet and savory snacks at certain times of the day. Still, this practice is not common in countries around the world, even among European countries. As a team of native French and Chinese speakers, we pointed out this problem and proposed two potential solutions: adding domestication to this question in the localized versions of our app or keeping the British spirit and translating directly. 

In the end, we agreed that as the background of the game remains Hogwarts, it is best that we maintain consistency across all versions and retain the British elements in the game.

Expanding on the discussion above regarding the linguistic part of localization for our game, one tool we found useful to better capture the spirit of the original theme is the Harry Potter Fandom databases. Official translations are kept in glossaries by enthusiastic fans and writers, helping us achieve better consistency and accuracy in portrayal. 

Nevertheless, though consistency is critical in terms of tone and voice, the sentence structures may need to vary from language to language in many cases. One observation that we had after localizing the game into seven different languages is that Chinese and Japanese quiz or question design in general have unique attributes not found in quizzes for other languages. When researching and brainstorming, we collected both official and unofficial Harry Potter sorting hat questions. There were clearly more questions that read “Please choose one of the following:” in Chinese and Japanese. Since our project is relatively small in scale, and question structures did not impact the nuance of the questions greatly, we chose to keep all questions structures consistent. But, in future localization projects that feature larger numbers of questions, this problem will be worth careful consideration.

## Challenges/lessons learned
C# is a great language for internationalization! 
Resource files should be completed AFTER the form properties are finalized (or you will have to start over). It proved once again that it is always good to have a backup, which was the Excel file in which we translated our externalized strings (Drive folder, access restricted to team members).
It would be quick to add other languages in the future. However, one element that may have to be reworked in our code is the function associated with the language selector: for now, it relies on the order of the languages in the list. In the future, we could rewrite the code so that the iso code used for Current(UI)Culture is found from the native name of the language selected.
Aesthetics do matter, but so do format standards and glyph data! When selecting fonts for text elements in C# programs in Visual Studio, rather than checking the visual effects of the font, verify that the format standard is compatible with VS, and the number, as well as type of glyphs, satisfy the requirements of the languages that you will be implementing.

## Potential Improvement Areas
### Music background
To bring Harry Potter’s atmosphere to our quiz, we thought of adding its music theme playing in the background. Game design was not the focus of the assignment, but figuring out how to implement this idea helped us explore more of C# Winform features. One first way to do it was to create two buttons (Play, Stop). In the code, we could use the built-in Media system and create a Soundplayer variable, then link it to the audio file (SoundLocation) and use Play and Stop functions as click events. Our research then led to the discovery of an even simpler way to play music in a Winform: Windows Media Player is a built-in component of the .NET framework. The item can be added in the toolbox, then embedded in the form and programmed in only a few lines of code. The advantage is that the users could not only play and stop the music, but also pause/resume and shift its volume. This works for videos as well. 
Code to use WMP in WinForm

However, the player’s design was not aesthetically pleasing for our game. In any case, while both solutions worked in a separate form, they did not work in our app, probably due to an error in the way we indicated how to get the audio resource file. Moreover, playing this file may have been illegal, as it is strongly protected by copyright. From an internationalization point of view, in other contexts, we may consider adapting the music content to the target audience. It would therefore be interesting to think about how to externalize the pathfinder so that the main code would not change but different files would be fetched depending on the locale.

### Start Menu and Ending Screen
Due to time constraints, we have yet to implement a start menu for our game, which we conceptualize to greet the players and set the overall mood for the game. 

In addition, we also plan on implementing an ending screen with visual elements pertaining to the house that the player is assigned, so as to enrich UI and enhance player engagement. 

### Code Optimization
Currently, our game assigns players with houses based on comparing the amount of answers accumulated relating to each house. If possible, we would like to add more randomization into the algorithm, to improve the unpredictability and entertainment of the game.


