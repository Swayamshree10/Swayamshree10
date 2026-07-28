git --version
git config --global user.name
git config --global user.email
git config --global --list
git config --global core.editor
git config --global -e
mkdir GitDemo
cd GitDemo
git init
ls -la
echo "Welcome to Git" > welcome.txt
cat welcome.txt
git status
git add welcome.txt
git commit
git remote add origin
git remote -v
git pull origin master
git push origin master