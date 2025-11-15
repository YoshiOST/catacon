# catacon
A command tool to reference catechisms and confessions on twitch!
a quotesbot spiritual successor. Tested on streamer.bot(0.2.4)

## Instructions, examples are from streamer.bot 0.2.4

### EASY IMPORT
1. Go here and download the catacon file.
2. You can open it then in the browser or notepad.
3. Then copy it and go to streamerbot and open the import dialog window and paste it at the top field and enjoy!
4. You still need to download the catechism texts and set the file location below.

## Manual Import


1. Download the cs files and the associated txt file.

![chrome_uMjUvF692n](https://github.com/user-attachments/assets/d0a7b54f-f48b-4154-8088-a17f5ee175b9)
  
3. Make sure you have streamer.bot

You need a command setup for each script to activate like so. This adding a command trigger such as core>commands>command triggered and a sub-action for c# scripts under core>c#>execute c# code

![Streamer bot_yd5yt6sLtw](https://github.com/user-attachments/assets/1a14dbd6-3d01-4684-9167-e24a9f327065)

add the script into the c# code, make sure the filepath matches where the text file is. for example for the london baptist file. ```...catacon\references\1689lbcf.txt```

![FSJAmAXyJj](https://github.com/user-attachments/assets/b8f16ced-7a83-4ee3-9178-4c13a0af4a87)

save & compile

5. Type the command in your chat and..
6. Success!


## Commands
| Command        | Description                                                                         |
| -------------- | ----------------------------------------------------------------------------------- |
|!bcf #          | for example !bcf 1 would quote the first confession of the belgic confession        |
|!cod #           | for example !cod 1 would quote the first confession of heidelberg catechism         |
|!wcf #          | for example !wsc 1 would quote the first confession of westminster shorter catechism|
|!wsc #          | for example !wsc 1 would quote the first confession of westminster shorter catechism|
|!wlc #          | for example !wlc 1 would quote the first confession of westminster longer catechism |
|!hc #           | for example !wlc 1 would quote the first confession of heidelberg catechism         |
|![command] next | means you will go to the next section of the text for example ```!wlc next          |

## Copyright Info
| Text                          | Source       |
| ----------------------------- | ------------ |
|Westminster Shorter Catechism  | Public Domain|
|Westminster Longer Catechism   | Public Domain|
|Heidelberg Catechism           | Public Domain|
|Belgic Confession              | Public Domain|
|1689 London Baptist Confession | Public Domain|
|Canons of Dort                 | Public Domain|

bcf done
hc done
wlc done
wsc done
wcf todo
cod
