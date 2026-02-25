# to-do-or-not-to-do
Simple to do list
Just want to make a very simple to-do list that I can run on my pc offline and not eating at my precious RAM.

to-do folder is using .NET framework, which I didn't realise is legacy and I could not publish it as a "standalone" .exe
hence why I made to-do-new that I made with .NET 8 and I could publish it as "standalone" .exe

tasks are simply stored in txt file
there is also another txt file for logs, logging date-time create/complete task-name

Just simply publish it or if you want to publish as "standalone" like i did:
- Right click project
- Publish
- New profile
- Choose folder; Do not choose ClickOnce
- Next
- Choose a folder
- Finish

Then in Publish settings (might need to Show All Settings):
- Configuration : Release
- Deployment Mode : Self-contained
- Target Runtime : win-x64
- File Options : Enable Produce single file and ReadyToRun

Save and Publish
