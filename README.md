# The-murderer-of-Mr.-Smith
Mr. Smith is a successful and influential individual who is in contact with many people from different regions. However, a shocking incident has occurred. At 9 a.m., the police station called. On the other end of the line, someone was talking about a heinous crime. Yes, Mr. Smith had been murdered in his own home. The police, after arriving at the crime scene, found no evidence, but upon careful examination, a strand of the killer's hair was discovered. After extensive questioning, the police discovered that Mr. Smith had been in contact with various individuals from 60 different countries. However, the police cannot make use of this information. Therefore, we want to provide a solution to find the similarity between the killer's DNA strand and the DNA of individuals from different countries. To do this, we need to compare the similarity between the killer's DNA and the registered DNA samples of individuals from 60 different countries, and select the most similar individuals. For each country, there are 10 registered DNA samples. The DNA sequence consists of various combinations of 20 characters. The figure below shows a part of the DNA sequence for several individuals. For each individual, there are two lines: the first line corresponds to their identification number, and the second line represents the DNA sequence of the individual, which is 25 characters long. Information for 600 individuals (60 countries with 10 individuals each) has been sent to you in a file named "Data." The file is organized in such a way that the first 10 individuals correspond to the first country, the next 10 individuals correspond to the second country, and so on.

# Section 1 :

"Write a function that takes the 'data' file and creates a folder for each country. The DNA information of different individuals from that country should be stored in separate folders. Therefore, in this section, 60 folders should be created with names ranging from 1 to 60, and inside each folder, 10 folders should be created for each individual. For each individual from each country, a folder should be created with the name being the identification number of the person. Then, inside the corresponding folder, a text file should be created to store only the DNA sequence of that individual. The file name should be the identification number of the person followed by '_DNA'."

# Section 2 :

Write a function that takes a DNA sequence file and determines the count of each character in that file. This information should be saved in a separate file with the name being the identification number of the individual followed by '_info'. The data in this file should be displayed in a dataGridView by selecting any of the files

# Section 3 :

Write a function that takes the DNA sequence of each individual and generates a file of numbers for each person. This function should replace each letter in the sequence with its ASCII code. Each number should be separated by a hyphen (-). This information should be stored in a file with the name 'identification number_digit'

# Section 4 :

The above functions should be applicable to the DNA sequence file of the killer, which is also named "killer". It should retrieve all the aforementioned information for this sequence and store it in a folder named "killer.

# Section 5 :

A function should be created to generate a similarity matrix. For this purpose, the similarity between the DNA sequence of the killer and the DNA sequences of registered individuals in each country should be compared. You can use the "digit" file for this purpose and store the differences between the numbers in these two files in the corresponding cell. The output of this stage should be a 60x10 matrix, where each number in the array represents the level of similarity between the DNA of the killer and a specific individual.

# Section 6 :

Write a function that takes the similarity matrix as input and determines the most similar individual to the killer in each country. Among these individuals, the top 10 most similar individuals are identified, and ultimately the most similar individual is determined. The identification numbers of the 10 most similar individuals should be displayed in a dataGridView.

پ
