export AZURE_STORAGE_CONNECTION_STRING=$AZURESCS

config.ssh.shell = "bash -c 'BASH_ENV=/etc/profile exec bash'"

CONTAINER_NAME=constructors-images
SOURCE_FOLDER=/buildimages/*

# Install the CLI
sudo npm install -g azure-cli

# Reload bash
source ~/.profile

azure

az storage container create -n $CONTAINER_NAME

for file in $SOURCE_FOLDER
do
  az storage blob upload --file $file --container-name $CONTAINER_NAME --name $BUILD_BUILDNUMBER
done
