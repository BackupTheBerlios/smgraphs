#!/bin/zsh
target="prebuild.tar.gz"
server='shell.berlios.de:~'
function Clean()
{
    echo "removing the $target"
    rm -rf $target
}
function Archive()
{
   echo "creating the archive" 
   tar -zcvf $target ../prebuild
   return $?     
}
function Upload()
{
    echo "uploading $target file to $server"
    scp $target $server
}
Archive&&Upload
Clean
