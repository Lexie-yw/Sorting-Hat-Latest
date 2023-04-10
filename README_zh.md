# 分院帽

## 项目概况

分院帽是一款问答游戏，可将用户分到霍格沃茨的四个学院之一。是时候探索魔法了！

游戏目前支持7种语言：英语、简体中文、法语、德语、西班牙语、日语和意大利语。

## 团队成员：

分院帽游戏是由 MIIS 的三名研究生（见下表）创建和本地化的。

Ellie (Zhiqing) Wu | Lexie (Yiwen) Wang | Maud Grasmenil
:-: | :-: | :-:
设计、本地化 | 游戏开发、本地化项目管理 | 国际化、本地化
zhiqingw@middlebury.edu, zhiqingwu1998@gmail.com | yw2@middlebury.edu, lexieyww@gmail.com | mgrasmenil@middlebury.edu, maud.grasmenil@gmail.com

<!---
Note: This project is the final course project for Software Internationalization and Localization, taught by Professor David Mohr (dmohr@middlebury.edu).
-->

[列出的名称按字母顺序排列]

## 介绍

### 项目构思

分院帽是一款 C# 游戏，灵感来自哈利波特电影和问答游戏机制。游戏中有 11 道选择题。根据用户对问题的回答，分院帽将用户分到霍格沃茨的四个学院之一。

### 游戏背景

霍格沃茨魔法学校有四个学院：格兰芬多学院、斯莱特林学院、拉文克劳学院和赫奇帕奇学院。房子的每个创始人对什么是好的巫术有不同的看法，所以房子的准入要求是不同的。被霍格沃茨录取的新生必须参加分院帽测试，才能知道他们将被分到哪个学院。

### 游戏规则

将有11道选择题，测试用户的兴趣、爱好、性格等，根据他们的回答，计算出一个结果，告诉用户他们会进入哪个房子。

### 外部资源参考

- Development Related: https://www.mooict.com/c-tutorial-create-a-simple-multiple-choice-quiz-game-in-visual-studio/
- Content Related: https://harrypotter.fandom.com/wiki/Harry_Potter
- Image Assets: https://unsplash.com/

## 产品开发

[工程：游戏源代码]：一般一个小测验只有一个结果，正确率（参考外部资源）。然而，在我们的问答游戏中，根据用户的回答，他们将从四种可能的结果中分配一个结果。为了实现这一点，代码逻辑如下所示：

每个问题有四个选择，每个选择都与霍格沃茨的学院有关。我们为每个选择分配一个标签（格兰芬多、斯莱特林、拉文克劳和赫奇帕奇）。然后，当我们将答案存储到数组时，我们不存储实际选择的字符串，而是存储标签。用户完成测验后，我们会计算数组中哪个标签（房子）出现频率最高，然后我们就可以将用户分配到那个房子。

<div>
<img src="./README%20assets/Code%20example.png"><p>代码示例：将标签存储到数组中。 </p>
<img src="./README%20assets/Non-localized%20product1.png" width="450" height="400"><img src="./README%20assets/Non-localized%20product1.png" width="450" height="400"><p>已完成的非本地化项目。</p>
</div>

## 项目管理

### 工作日志：

There are mainly four development stages: Ideation, Game Development [Source Code], Internationalization, and Localization. We created a product development plan [Progress Tracker] to follow and met five times either in person or online to complete the project.

<div>   <img src="./README%20assets/Product%20development%20plan.png" height="500" width="500">    <img src="./README%20assets/worklog.png" height="300" width="300">   <p>Product development plan and work log.</p> </div>

### Localization File Management:

Good management of assets is a must for successful localization. Sorting Hat has three types of assets regarding localization: Media, Source Text, and Translations. To make sure those assets are well organized and easily accessible, they were well categorized and put into three different folders on Google Drive.

<div>   <img src="./README%20assets/Drive%20folder%20structure.png" height="500" width="500">   <img src="./README%20assets/Media%20folder.png" height="300" width="300">   <p>Google Drive folder structure and assets under Media folder.</p> </div>

### Tools:

To ensure smooth collaboration between product, engineering, and the localization team, we used Visual Studio Community &amp; GitHub for code development, Google drive for general file management, Whatsapp for progress updates and debugging chat, and Zoom for online meetings.

<div>   <img src="README%20assets/Git%20Repo.png">   <p>GitHub repository for the Sorting Hat game.</p> </div>

## Internationalization

Localization starts at the earliest stage of a game’s development. In that regard, the .NET framework made app internationalization rather easy. Once the windows form was properly internationalized, we only had to add text in the different resource files.

### Engineering

1. We created a language switcher: with a list of the different languages. To the Dropdown list, a function is assigned that first gets the cultural info of the selected locale (Switch/case), applies it (CurrentCulture &amp; CurrentUICulture), then clears and reinitializes the form. The CultureInfo object allowed us to adapt some cultural elements to the target locale, such as the date format used in the final text.

<div>   <img src="README%20assets/Language%20Switcher.png">   <p>Code example: language switcher.</p> </div>

1. Internationalization can be done in the Form properties (Designer.cs, “Localizable”: True). Switching from default to the different locales automatically creates new resource files for each locale, in which we can put the variables and their corresponding strings.

2. String externalization was then implemented in the code by creating variables instead of strings (getting attributed strings in resource files) and avoiding concatenation.

<div>   <img src="README%20assets/Externalized%20Strings.png">   <p>Externalized strings in the en-US resource file.</p> </div>

### Design internationalization

Other elements had to be taken into consideration in the internationalization process. Text size: The size of the text had to be adapted for each locale to ensure its readability (Chinese characters smaller, for instance). Box size: Similarly, once strings were translated, we realized that some questions were too long in certain locales, overflowing the textbox (the extra text would not display). We therefore adapted the size of the text boxes when needed. In the future, it would be better to make the boxes automatically resizable so they can adapt to the length of their content. Layout: some layout issues occurred for some locales: the position of the language label changes in the French (France). Correcting it would reinitialize our resource files, therefore, due to time constraints, it hasn’t been done yet. This showed us that design had to be finalized before adding the strings in the resource files. Another solution we would like to explore is to create resource files for externalized strings that would be independent from the Form.cs file. Language: Encoding: we wanted to ensure that all of the languages would be properly encoded and that others could be indeed later on. We, therefore, used the Unicode standard. Font: we had to ensure that they would work for all languages (esp. Chinese and Japanese characters). An idea was to use different fonts for Latin script and Chinese and Japanese script.

## Design

### General UI design

Following the theme of the sorting hat, the basic concept of our UI design mirrors the overall aesthetics of the Harry Potter movies, as well as other spinoffs of the franchise. More specifically, we aimed to replicate the sorting hat quiz offered on the Pottermore website, which evaluates the users’ answers in a set of short multiple-choice questions relating to the Harry Potter series.

In an attempt to recreate the medieval gothic architectural style of the setting of the original story, Hogwarts School of Witchcraft and Wizardry, we chose a dark color scheme for the UI, paired with a crinkled, sepia-colored paper texture in the background.

One challenge in the design process is to choose the proper colors for the answer choice buttons. As mentioned previously, the four houses each possess an individual representative color, red, yellow, blue, and green, respectively. To avoid using the same color as any one of the houses, we built the buttons with black backgrounds and orange text, solving the problem while retaining the medieval style and increasing legibility.

### Font Selection

Building upon the previous section, another aspect in the general UI design process of this game involves finding a font that further highlights the style. In this case, the font for the Latin-script alphabet that we chose after careful consideration is Xéfora, which is modeled after the font style of Harry Potter movie posters. As mentioned earlier, we adopted the Unicode standard to include the characters needed for the languages that we localized into. So, another criterion for font selection for us was to choose one that contains all characters needed, along with essential accent marks for Spanish, French, and German. On the other hand, as for the two CCJK, or C(hinese) J(apanese) languages we chose, we encountered similar problems when selecting fonts. Though one font named Oriental was shortlisted for Japanese, it only supports one out of three Japanese writing systems. Therefore, we decided to leave the Chinese and Japanese versions of our game in the default font.

<div>   <img src="README%20assets/German%20UI.png" width="500" height="350">   <img src="README%20assets/Spanish%20UI.png" width="500" height="350">   <p>The Sorting Hat game UI localized into German and Spanish.</p> </div>

Circling back to the chosen font, although it works for all of the non-CCJK versions of our game, the font is yet to be embedded, meaning that it only shows when the operating system has Xéfora installed. A demo of the game with the stylized font is shown below.

Another problem, and perhaps the most critical one, that we encountered during font implementation was the limitation of Visual Studio with font types. First of all, Visual Studio only supports TrueType fonts (TTF), so OpenType fonts are to be avoided for similar projects in the future.

## Localization

For localization, the challenge that was apparent throughout the process is foreignization versus domestication.

The goal of our final deliverable is to, again, emulate the style of the original Pottermore quiz. Therefore, many concepts unique to the UK were introduced in the questions. One example of such is a question regarding teatime snacks. It is common knowledge that people from the UK often enjoy tea with a variety of sweet and savory snacks at certain times of the day. Still, this practice is not common in countries around the world, even among European countries. As a team of native French and Chinese speakers, we pointed out this problem and proposed two potential solutions: adding domestication to this question in the localized versions of our app or keeping the British spirit and translating directly.

In the end, we agreed that as the background of the game remains Hogwarts, it is best that we maintain consistency across all versions and retain the British elements in the game.

Expanding on the discussion above regarding the linguistic part of localization for our game, one tool we found useful to better capture the spirit of the original theme is the Harry Potter Fandom databases. Official translations are kept in glossaries by enthusiastic fans and writers, helping us achieve better consistency and accuracy in portrayal.

Nevertheless, though consistency is critical in terms of tone and voice, the sentence structures may need to vary from language to language in many cases. One observation that we had after localizing the game into seven different languages is that Chinese and Japanese quiz or question design in general have unique attributes not found in quizzes for other languages. When researching and brainstorming, we collected both official and unofficial Harry Potter sorting hat questions. There were clearly more questions that read “Please choose one of the following:” in Chinese and Japanese. Since our project is relatively small in scale, and question structures did not impact the nuance of the questions greatly, we chose to keep all questions structures consistent. But, in future localization projects that feature larger numbers of questions, this problem will be worth careful consideration.

## Challenges/lessons learned

C# is a great language for internationalization! Resource files should be completed AFTER the form properties are finalized (or you will have to start over). It proved once again that it is always good to have a backup, which was the Excel file in which we translated our externalized strings (Drive folder, access restricted to team members). It would be quick to add other languages in the future. However, one element that may have to be reworked in our code is the function associated with the language selector: for now, it relies on the order of the languages in the list. In the future, we could rewrite the code so that the iso code used for Current(UI)Culture is found from the native name of the language selected. Aesthetics do matter, but so do format standards and glyph data! When selecting fonts for text elements in C# programs in Visual Studio, rather than checking the visual effects of the font, verify that the format standard is compatible with VS, and the number, as well as type of glyphs, satisfy the requirements of the languages that you will be implementing.

## Potential Improvement Areas

### Music background

To bring Harry Potter’s atmosphere to our quiz, we thought of adding its music theme playing in the background. Game design was not the focus of the assignment, but figuring out how to implement this idea helped us explore more of C# Winform features. One first way to do it was to create two buttons (Play, Stop). In the code, we could use the built-in Media system and create a Soundplayer variable, then link it to the audio file (SoundLocation) and use Play and Stop functions as click events. Our research then led to the discovery of an even simpler way to play music in a Winform: Windows Media Player is a built-in component of the .NET framework. The item can be added in the toolbox, then embedded in the form and programmed in only a few lines of code. The advantage is that the users could not only play and stop the music, but also pause/resume and shift its volume. This works for videos as well. Code to use WMP in WinForm

However, the player’s design was not aesthetically pleasing for our game. In any case, while both solutions worked in a separate form, they did not work in our app, probably due to an error in the way we indicated how to get the audio resource file. Moreover, playing this file may have been illegal, as it is strongly protected by copyright. From an internationalization point of view, in other contexts, we may consider adapting the music content to the target audience. It would therefore be interesting to think about how to externalize the pathfinder so that the main code would not change but different files would be fetched depending on the locale.

### Start Menu and Ending Screen

Due to time constraints, we have yet to implement a start menu for our game, which we conceptualize to greet the players and set the overall mood for the game.

In addition, we also plan on implementing an ending screen with visual elements pertaining to the house that the player is assigned, so as to enrich UI and enhance player engagement.

### Code Optimization

Currently, our game assigns players with houses based on comparing the amount of answers accumulated relating to each house. If possible, we would like to add more randomization into the algorithm, to improve the unpredictability and entertainment of the game.
