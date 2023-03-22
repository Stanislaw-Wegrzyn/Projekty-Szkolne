# SKOPJUJ PRZED URUCHOMIENIEM!
"""
var answ = ["jQuery is a JavaScript Library      ","True      ","the $ sign      ","All div elements    Correct answer  ","Client scripting      ","Yes      ","False      ","$(\"p\").css(\"background-color\",\"red\");      ","All div elements with class=\"intro\"      ","hide()      ","css()      ","jQuery.ajax()      ","$(\"div\").height(100)    Correct answer  ","To use jQuery, you can refer to a hosted jQuery library at Google      ","JavaScript      ","$(document).ready()      ","noConflict()      ","toggleClass()      ","All p elements inside a div element      ","No      ","The p element with id=\"intro\"      ","Both methods can be used      ","All disabled input elements      ","parent()      ","Only properties containing numeric values      "];

var nr = document.getElementsByTagName("h3")[20].innerText.split(" ")[1] 
var label1 = document.getElementById("label1");
var label2 = document.getElementById("label2");
try {var label3 = document.getElementById("label3");} catch (error) {console.log(error);}
try {var label4 = document.getElementById("label4");} catch (error) {console.log(error);}

answ[nr - 1] = answ[nr - 1].replaceAll("Correct answer", "")

if (label1.innerText == answ[nr - 1].slice(0, -6)) {
  label1.click();
} else if (label2.innerText == answ[nr - 1].slice(0, -6)) {
  label2.click();
} else if (label3.innerText == answ[nr - 1].slice(0, -6)) {
  label3.click();
} else if (label4.innerText == answ[nr - 1].slice(0, -6)) {
  label4.click();
}

document.getElementsByClassName("answerbutton w3-btn ws-green")[0].click();
"""

import pyautogui, time

input("start?")
time.sleep(3)

for i in range(25):
    time.sleep(0.8)
    pyautogui.hotkey('ctrl', 'shift', 'k')
    pyautogui.hotkey('ctrl', 'v')
    pyautogui.keyDown('enter')
    pyautogui.keyUp('enter')