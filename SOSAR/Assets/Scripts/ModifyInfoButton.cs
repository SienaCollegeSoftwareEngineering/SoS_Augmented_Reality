using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ModifyInfoButton : MonoBehaviour
{
    public Button moreInfoButton;
    public TMP_Text newText;
    public TextMeshProUGUI buttonLabel;
    public static string global_TextForNewScene;
    public static string global_ProfNameForNewScene;

    public static string global_ProfDepartmentForNewScene;
    public static string global_ProfImageForNewScene;
    public static string global_PlaqueInfo;
    
    public void changeButtonText(string plaqueInfo) {
        moreInfoButton = GameObject.Find("NewInfoButton").GetComponent<Button>();
        moreInfoButton.interactable = true;
        global_PlaqueInfo = plaqueInfo;
        Debug.Log(global_PlaqueInfo);
        newText = GameObject.Find("InfoButtonText").GetComponent<TMP_Text>();
        newText.text = "More info";
        Debug.Log(newText.text);
    }

    public void disableButton() {
        if (moreInfoButton != null) {
            global_PlaqueInfo = "Waiting...";
            newText.text = "Waiting...";
            moreInfoButton.interactable = false;
        }
    }

    public void goToMoreInfoRoom() {
        Debug.Log("Going to " + global_PlaqueInfo);
        changeTextForNewScene();
        SceneManager.LoadScene("More Info Scene");
    }



    /*
    * For professor names: <align=\"center\"><color=#006B54><size=28px> text </size></color></align><br>
    * For headings: <align=\"center\"><color=#006B54><size=26px> text </size></color></align><br>
    * For content: <color=>
    * "<align=\"center\"><color=#006B54><size=28px>Professor </size></color></align><br><br><align=\"center\"><color=#006B54><size=26px>Classes I Teach</size></color></align><br><br>";
    */
    public void changeTextForNewScene() {
        switch(global_PlaqueInfo) {
            #region Roger Bacon (RB)
            // 3rd floor
            case "RB350":
                global_TextForNewScene = "<color=#1ab2c5><align=\"center\">Roger Bacon 350</color></align><br><br>It is the open lab where you can come to do homework and study. You might also have a class or exam in here.";
            break;
            case "RB348":
                global_TextForNewScene = "<align=\"center\"><color=#006B54><size=28px>Roger Bacon 348</size></color></align><br><br>This is the Software Engineering Lab. Students taking CSIS-410 (Software Engineering I) and CSIS-415 (Software Engineering II) have labs and develop semester long apps in here. Often, you'll see students hunkered down here, hard at work on their projects.<br><br><align=\"center\"><color=#006B54><size=26px>Fun Facts</size></color></align><br>This app was made in this room!";
            break;
            case "RB340":
                global_TextForNewScene = "<align=\"center\"><color=#006B54><size=28px>Roger Bacon 340</size></color></align><br><br>RB340 is a large classroom on the 3rd floor, shared by many different majors. Not only are classes held here, but also club meetings and events.";
            break;
            case "RB338": // Egan
                global_TextForNewScene = "<align=\"center\"><color=#006B54><size=28px>Dr. MaryAnne Egan</size></color></align><br><br><align=\"center\"><color=#006B54><size=26px>About</size></color></align><br>Dr. Egan recognizes and works to act on the issues of underrepresentation in Computer Science. She has worked on grants to increase the number of Computer Science teachers in NY, is involved in the Women in Computer Science Club, and often teaches students how to make their developed applications more accessible for everyone.<br>\"Having been around Siena most of my life (my dad taught here), I see how the professors really care about the students and that the people are amazing. The small teacher to student ratio makes it easy for professors to discover individual students' talents and suggest ways to help them learn and improve. \"<br><align=\"center\"><color=#006B54><size=26px>Classes I Teach</size></color></align><br>CSIS180: Web Design, CSIS110: Introduction to Computer Science, CSIS200: Diversity in Computer Science<br><align=\"center\"><color=#006B54><size=26px>Clubs</size></color></align><br>Women in Computing.  This club is a great way to involve and engage women in the computer science field. We provide valuable networking between Siena students and successful career professionals by encouraging attendance to various computer science conferences.<br><br><align=\"center\"><color=#006B54><size=26px>Hobbies + Interests</size></color></align><br>Dr. Egan likes to travel, so much so she has been to all 7 continents. She also enjoys movies, crafts, cool new tech and her grandkids. Her favorite play is <i>Hamilton</i>";
            break;
            case "RB332": // Chaudhari
                global_TextForNewScene = "<align=\"center\"><color=#006B54><size=28px>Professor Ninad Chaudhari</size></color></align><br><br><align=\"center\"><color=#006B54><size=26px>About</size></color></align><br>Ninad got interested in software development after helping a local hospital upgrade its EMR from MS Excel. He leads the software development team at the University At Albany Software Engineering Research Lab, and he is pursuing a doctoral degree there as well. \"I love the camaraderie between the faculty. Their devotion to teaching while being accomplished researchers is remarkable. Small class sizes at Siena enable me to connect with students and have frequent and meaningful interactions, which is rewarding. A welcoming community with diverse interests has helped me create a space for sustained and shared knowledge creation. Moreover, I appreciate the strong alumni network and excellent outreach programs that let students experience real-world engineering challenges in an academic setting.\"<br><br><align=\"center\"><color=#006B54><size=26px>Classes I teach</size></color></align><br>CSIS110: Introduction to CS with Python and Multimedia, CSIS011: Problem Solving with Spreadsheets, ICSI418/518 Software Engineering (University at Albany)<br><br><align=\"center\"><color=#006B54><size=26px>Interests + Hobbies</size></color></align><br>Ninad is a renowned athlete in shooting, he holds numerous national records and medals in the Indian National Rifle Shooting team ";
            break;
            case "RB328":
                global_TextForNewScene = "<align=\"center\"><color=#006B54><size=28px>Roger Bacon 328</size></color></align><br><br>RB328 is a large classroom that is a hub for activity on the third floor. Many classes are held here, as well as meetings by the Computer Science and Cyber Security Clubs.";
            break;
            case "RB326": // Liu
                global_TextForNewScene = "With research interests in Computational Sociolinguistics, Natural Language Processing, AI and Machine Learning, Dr. Liu is the one to go to to ask about the ever changing world of Computer Science. His current area of research is on general AI, which teaches robots to learn like kids.\"I really enjoy teaching in the class and working with my students during the research. We have very dedicated and intelligent students, who clearly know their goals and responsibilities to the society and therefore are willing to put their time and efforts into preparing for their brilliant future. I also very much enjoy working with my colleagues. We not only share the ideas and experiences to improve the teaching/learning quality but also collaborate tightly to work on the very challenging research problems in Computer Science area.\"Classes I Teach - CSIS120: Software Development, CSIS210: Data Structures, CSIS370: Robotics, CSIS375: Intro to AI";
                global_ProfNameForNewScene = "Dr. Ting Liu";
                global_ProfDepartmentForNewScene = "Computer Science";
                //global_ProfImageForNewScene = "Ting.JPG";
            break;
            case "RB324":
                global_TextForNewScene = "<align=\"center\"><color=#006B54><size=28px>Roger Bacon 324</size></color></align><br><br>RB324 is the CS Library, a room that contains numerous books on several topics, ranging from programming languages to topics in mathematics to cryptography. It is a private room where you can take tests or hold meetings.";
            break;
            case "RB323": // Matthews
                global_TextForNewScene = "<align=\"center\"><color=#006B54><size=28px>Professor James Matthews</size></color></align><br>Most every Computer Science student will have to take math classes, and they'll most likely take them with Professor Matthews. His high enthusiasm for mathematics will leave students with many fond memories from his classes.<br><br>Outside of the classroom, Professor Matthews focuses on STEM Education. He is a national leader in Math and Computer Science education and is a monumental part of organizing the yearly High School Programming event, where teams of high school students come to Siena for friendly competition.<br><align=\"center\"><color=#006B54><size=26px>Classes I Teach</size></color></align><br><br>MATH010: Finite Mathematics, MATH250: Discrete Mathematics, MATH350: Theory of Computation, CSIS110: Intro to Computer Science<br><br><align=\"center\"><color=#006B54><size=26px>Hobbies + Interests</size></color></align><br>Professor Matthews likes to run, bike, hike and ski. He also enjoys puzzles and games, magic, reading and hanging out with his friends and families.";
            break;
            case "RB322":
                global_TextForNewScene = "<align=\"center\"><color=#006B54><size=28px>Roger Bacon 322</size></color></align><br><br>RB322 is a large room, used by many different classes for labs.";
            break;
            case "RB321": // Armitage
                global_TextForNewScene = "<align=\"center\"><color=#006B54><size=28px>Professor Jack Armitage</size></color></align><br>Professor Armitage has done a wide range of IT jobs during his 30 years in the industry. Even with all this experience, Professor Armitage still learns from his students everyday. <br><br>\"I went to UAlbany and had 500 students in several freshman classes. Overwhelming. So big it was hard to get to know your professors. You don't get that here at Siena. Small class sizes, friendly faculty, great kids, and a feeling of belonging. There are many opportunities to get involved and do service work. You just can't beat it.\"<br><br><align=\"center\"><color=#006B54><size=26px>Classes I teach</size></color></align><br>Cyber Security, Management Information Systems, Databases<br><br><align=\"center\"><color=#006B54><size=26px>Clubs</size></color></align><br>Professor Armitage is a part of the Cyber Security Club, a very new club to campus. The club discusses current events in cyber, while enjoying pizza and soda at meetings.<br><br><align=\"center\"><color=#006B54><size=26px>Interests + Hobbies</size></color></align><br>Professor Armitage likes to hike and play golf. His favorite movie is <i>The Shining</i>.";
            break;
            case "RB320": // Breimer
                global_TextForNewScene = "<align=\"center\"><color=#006B54><size=28px>Dr. Eric Breimer<br></size></color></align><br><align=\"center\"><color=#006B54><size=26px>About</size></color></align><br>Dr. Breimer joined Siena in 2002 and teaches a wide range of classes from Machine Learning to Web Application Development to Analysis of Algorithms. His research focuses on improving teaching Computer Science through innovative web technology and applying Machine Learning to solve interactive problems.<br><br>\"At Siena, students can get a timeless Liberal Arts education and an outstanding Computer Science education in one place. I believe a Liberal Arts education is the foundation of life-long learning and Computer Science compliments this foundation by teaching computational thinking and problem solving proficiency which are incredibly valuable in so many different career paths.\"<br><br><align=\"center\"><color=#006B54><size=26px>Classes I teach</size></color></align><br>Intro to Data Science, Management Information Systems, Theory of Computation, Web Application Development, Programming in Java, Machine Learning, Analysis of Algorithms, Data Structures, Web Design.<br><br><align=\"center\"><color=#006B54><size=26px>Interests + Hobbies</size></color></align><br>Dr. Breimer loves to kayak and row (scull). He is a US Rowing certified coach and Vice President of Albany Rowing Center. His 2K personal record is 6:47.";
            break;
            case "RB319": // Cotler
                global_TextForNewScene = "Dr. Cotler strives to aid students in preparing for their lives and careers outside of college through teaching them skills like professionalism and managing interpersonal relationships with colleagues. The course work she teaches is designed to be applicable to finding and excelling in jobs after college. \"I have worked at Siena in a variety of roles for over the past twenty five years. During this time, what I love most has been interacting and working with our students in and out of the traditional classroom. I find it extremely rewarding to watch students discover their talents. I appreciate the opportunities I have had to collaborate and work with exceptional colleagues across disciplines and departments at Siena.\" Courses I teach - CSIS410/415: Software Engineering I & II, CSIS400: UX Design and Human-Computer Interaction, CSIS411: Senior Seminar, ATVD220: Yoga and Meditation"; //Clubs - Dr. Cotler is part of ACM-W, an organization that advocates internationally for the engagement of women in the various computing fields. Interests + Hobbies - Dr. Cotler likes distance swimming and running, biking, travel, triathlons and yoga. She also likes indoor and outdoor gardening.";
                global_ProfNameForNewScene = "Dr. Jami Cotler";
                global_ProfDepartmentForNewScene = "Computer Science";
            break;
            case "RB318": // Small
                global_TextForNewScene = "<align=\"center\"><color=#006B54><size=28px>Dr. Sharon Small</size></color></align><br><br><align=\"center\"><color=#006B54><size=26px>About</size></color></align><br>Dr. Small's main area of research is in Computational Linguistics, a field of Artificial Intelligence. At SUNY Albany, she was the lead research scientist under the AQUAINT program funded by the federal government. She receives numerous federal grants which she utilizes to fund students to work in Computational Linguists.<br><br>\"The freedom to explore new teaching styles is one of the things I most enjoy about Siena College. Being able to bring this new type of fully interactive classroom and exciting research opportunities to the superior students at Siena is at the foundation of my teaching philosophy.\"<br><br><align=\"center\"><color=#006B54><size=26px>Classes I teach</size></color></align><br>CSIS120: Introduction to Software Development, CSIS370: Robotics, CSIS401: AI Research<br><br><align=\"center\"><color=#006B54><size=26px>Interests + Hobbies</size></color></align><br>Dr. Small's favorite movie is <i>Star Wars</i> and she's an avid hiker, having hiked in the Adirondacks.";
            break;
            case "RB317": // Goldstein
                global_TextForNewScene = "<align=\"center\"><color=#006B54><size=28px>Dr. Ira Goldstein</size></color></align><br><br><align=\"center\"><color=#006B54><size=26px>About</size></color></align><br>In high school, Dr. Goldstein used to stay after and run custom programs on his school's IBM 1620 (a modern 8 GB computer has around 200,000 times as much memory as that!) He has managed an information technology center and been a broadcast engineer before teaching.<br><br><align=\"center\"><color=#006B54><size=26px>Classes I teach</size></color></align><br>CSIS100: Introduction to Computer Science, CSIS365: Networking, CSIS400: Unix/Linux<br><br><align=\"center\"><color=#006B54><size=26px>Interests + Hobbies</size></color></align><br>Dr. Goldstein enjoys photography. One of his photos was once chosen by Wikipedia as the picture of the day.";
            break;
            case "RB316": // Lim
                global_TextForNewScene = "<align=\"center\"><color=#006B54><size=28px>Dr. Darren Lim</size></color></align><br><br><align=\"center\"><color=#006B54><size=26px>About</size></color></align><br>Dr. Lim has done research in artificial intelligence and education, as well as having previously taught classes in Game Development and Android Application Development. He is also the current Director of the Core Curriculum, which includes FYSM-100/105 and the current Core Disciplinary/Franciscan courses.<br><br><align=\"center\"><color=#006B54><size=26px>Classes I teach</size></color></align><br>CSIS390: Web Application Development, FYSM100/105: First Year Seminar I & II<br><br><align=\"center\"><color=#006B54><size=26px>Clubs</size></color></align><br>Dr. Lim is the advisor to the Computer Science Club. The club discusses topics related to the field as well having guest speakers throughout the year. It is open to every student in any major interested in Computer Science, and often the club plays trivia at meetings.<br><br><align=\"center\"><color=#006B54><size=26px>Interests + Hobbies</size></color></align><br>Dr. Lim is an avid trivia enthusiast, playing in both pub and app versions. He also loves movies, anything related to Disney, and sports (particularly Philly-based, Union College Hockey and Arsenal FC).";
            break;
            case "RB315": // Flatland
                global_TextForNewScene = "<align=\"center\"><color=#006B54><size=28px>Dr. Robin Flatland</size></color></align><br><br><align=\"center\"><color=#006B54><size=26px>About</size></color></align><br>Dr. Flatland has done research in Computer Science Education and Computational Geometry. She researches how to increase diversity in CS and arithmetic problems related to wireless communication networks and robotics.<br><br>\"Siena offers a first class CS education within a welcoming and supportive community of students, faculty, and alums. Siena's small classes allow me to offer students interactive learning experiences and connect with and mentor students.\"<br><br><align=\"center\"><color=#006B54><size=26px>Classes I teach</size></color></align><br>CSIS385: Design & Analysis of Algorithms, CSIS110: Introduction to CS with Python and Multimedia<br><br><align=\"center\"><color=#006B54><size=26px>Interests + Hobbies</size></color></align><br>Dr. Flatland likes to cook and swim, and her favorite movie is <i>The Imitation Game</i>";
            break;
            case "RB314": // DiTursi
                global_TextForNewScene = "<align=\"center\"><color=#006B54><size=28px>Dr. Dan DiTursi</size></color></align><br><br><align=\"center\"><color=#006B54><size=26px>About</size></color></align><br>Dr. DiTursi started programming in 3rd grade when he received a Commodore VIC-20 home computer. He has been teaching for a long time as well, being a K-12 teacher before coming to Siena. He believes that in college, students should learn how to use their independence and create success from it.<br><br> \"This is a special group of people who are very interested in honing their craft as educators and in supporting our students in any way they can. Running into someone in the hallway or the quad nearly always leads to an interesting conversation. Siena is the only place I've ever worked where I always look forward to showing up each day.\"<br><br><align=\"center\"><color=#006B54><size=26px>Classes I teach</size></color></align><br>CSIS320: Machine Learning, CSIS375: Intro to Artificial Intelligence, CSIS400: Cryptography<br><br><align=\"center\"><color=#006B54><size=26px>Interests + Hobbies</size></color></align><br>Dr. DiTursi has been a sports official since 15, refereeing for baseball, lacrosse and football. He also loves games of all varieties, including board games and video games.";
            break;
            case "RB313": // Vandenberg
                global_TextForNewScene = "<align=\"center\"><color=#006B54><size=28px>Dr. Scott Vandenberg</size></color></align><br><br><align=\"center\"><color=#006B54><size=26px>About</size></color></align><br>Dr. Vandenberg started programming on an Apple II in a high school class. He specializes in databases, having co-authored the books <i>Database Concepts</i> and <i>Database Processing</i><br><br>\"The students and faculty share the same goals, and I think everyone realizes this. We have a great relationship with alumni: they return to campus to speak with current students, and that willingness says a lot about the long-term success of Siena and how we're guiding the students to lifelong learning.\"<br><br><align=\"center\"><color=#006B54><size=26px>Classes I teach</size></color></align><br>CSIS110: Introduction to Computer Science, CSIS350: Database Management Systems<br><br><align=\"center\"><color=#006B54><size=26px>Interests + Hobbies</size></color></align><br>Dr. Vandenberg enjoys playing hockey and Medieval history. His favorite movie is <i>The Seventh Seal</i>";
            break;
            case "RB312":
                global_TextForNewScene = "<align=\"center\"><color=#006B54><size=28px>Roger Bacon 312</size></color></align><br><br>RB312, commonly known as the CS Lounge, is a room for CS majors to study and socialize. Off of the lounge is the CS Library and many professor’s rooms.";
            break;
            case "RB311": // White
                global_TextForNewScene = "<align=\"center\"><color=#006B54><size=28px>Professor Pauline White</size></color></align><br><br><align=\"center\"><color=#006B54><size=26px>About</size></color></align><br>Professor White has taught Computer Science at levels from 7th grade to the undergraduate level. She is an exam reader for the high school AP Computer Science A Exam. She is an advocate for supporting Computer Science teachers in NYS.<br><br><align=\"center\"><color=#006B54><size=26px>Classes I teach</size></color></align><br>CSIS120: Introduction to Software Development, CSIS210: Data Structures, CSIS220: Assembly Language and Computer Architecture";
            break;
            case "RB308": // Teresco
                global_TextForNewScene = "<align=\"center\"><color=#006B54><size=28px>Dr. James Teresco</size></color></align><br><br><align=\"center\"><color=#006B54><size=26px>About</size></color></align><br>Dr. Teresco discovered programming with the Atari 2600 and Commodore 64. A big moment in his career came when he had the idea to use highway data and maps to improve a Data Structures lab. This evolved into his Map-Based Educational Tools to Algorithm Learning (METAL) project. This project helps students learn about algorithms with real highway data in an interactive way. This program is used in some CS classes and numerous students have contributed to its ongoing development.<br><br><align=\"center\"><color=#006B54><size=26px>Classes I teach</size></color></align><br> CSIS335: Parallel Processing, CSIS330: Operating Systems, CSIS210: Data Structures, CSIS225: Advanced Programming, CSIS285: Analysis of Algorithms, CSIS301: Programming C in Unix, CSIS011: Problem Solving with Spreadsheets<br><br><align=\"center\"><color=#006B54><size=26px>Interests + Hobbies</size></color></align><br>Dr. Teresco likes baseball, traveling, and skiing.";
            break;
            case "RB306":
                global_TextForNewScene = "<align=\"center\"><color=#006B54><size=28px>Roger Bacon 306</size></color></align><br><br>RB306 is a room used for CS labs.";
            break;
            case "RB304":
                global_TextForNewScene = "<align=\"center\"><color=#006B54><size=28px>Roger Bacon 304</size></color></align><br><br>RB304 is a room used for CS labs.";
            break;
            case "RB302":
                global_TextForNewScene = "<align=\"center\"><color=#006B54><size=28px>Roger Bacon 302</size></color></align><br><br>RB302 is a common classroom on the third floor. Lectures in Computer Science and Physics are commonly taught here.";
            break;
            // 2nd Floor
            case "RB256":
                global_TextForNewScene = "RB256";
            break;
            case "RB254":
                global_TextForNewScene = "RB254";
            break;
            case "RB248":
                global_TextForNewScene = "RB248";
            break;
            case "RB240":
                global_TextForNewScene = "RB240";
            break;
            case "RB238":
                global_TextForNewScene = "RB238";
            break;
            case "RB236":
                global_TextForNewScene = "RB236";
            break;
            case "RB235":
                global_TextForNewScene = "RB235";
            break;
            case "RB231":
                global_TextForNewScene = "RB231";
            break;
            case "RB230":
                global_TextForNewScene = "RB230";
            break;
            case "RB229":
                global_TextForNewScene = "RB229";
            break;
            case "RB227":
                global_TextForNewScene = "RB227";
            break;
            case "RB226":
                global_TextForNewScene = "RB226";
            break;
            case "RB225":
                global_TextForNewScene = "RB225";
            break;
            case "RB224A":
                global_TextForNewScene = "RB224A";
            break;
            case "RB224":
                global_TextForNewScene = "RB224";
            break;
            case "RB223":
                global_TextForNewScene = "RB223";
            break;
            case "RB222":
                global_TextForNewScene = "RB222";
            break;
            case "RB221":
                global_TextForNewScene = "RB221";
            break;
            case "RB219":
                global_TextForNewScene = "RB219";
            break;
            case "RB212":
                global_TextForNewScene = "RB212";
            break;
            case "RB210":
                global_TextForNewScene = "RB210";
            break;
            case "RB208":
                global_TextForNewScene = "RB208";
            break;
            case "RB204":
                global_TextForNewScene = "<align=\"center\"><color=#006B54><size=28px>Dr. John Cummings</size></color></align><br><br>Dr. Cummings areas as a Dean include School of Science Office, Department of Biology, Department of Chemistry and Biochemistry, Department of Computer Science, and more!<br><br>\"Nothing is the matter with people, they have just been trained that rote memorization of facts and recipes is the easiest way to perform well in an academic setting. As an instructor my goal is to set up a classroom environment that encourages and rewards true understanding, while discouraging rote memorization. I want to harden fragile knowledge and make it robust.\"";
            break;
            case "RB202":
                global_TextForNewScene = "RB202";
            break;

            #endregion

            #region Siena Hall (SH)

            #endregion

            #region Morell Science Center (MSC)

            #endregion

            #region Foy Hall (FOY)

            #endregion

            #region Kinernan Hall (KH)

            #endregion

            #region Rosetti Hall (ROS)

            #endregion

            default:
                global_TextForNewScene = "Either you forgot to set the room, the room you set does not exist or you spelt it wrong, or it is not in the switch statement yet.";
            break;
        }
    }

    
}