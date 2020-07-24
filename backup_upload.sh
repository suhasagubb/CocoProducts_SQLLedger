#!/bin/bash

set -eo pipefail
# enable set -x below by uncommenting the line for debugging script. This would print each line on terminal window
# set -x

FOLDER="$(dirname $0)/DataBakcup/"
FILE="cocoaccounts$(date +%Y%m%d)"
PGPASSWORD="PGPASSWORD=<PASSWORD HERE>"
export ${PGPASSWORD}; pg_dump -U postgres cocoproducts > gzip -c > "${FOLDER}/${FILE}.sql.gz"
echo "ok - Daily back up of accounts occurred unless there were error messages above"

wait

if [ -f "${FOLDER}/${FILE}.sql.gz" ]; then
    "$(dirname $0)/../Downloads/azcopy_linux_amd64_10.4.3/azcopy" cp "${FOLDER}/${FILE}.sql.gz" "<URL of Virtual Container>${FILE}.sql.gz<SAS TOKEN>"
    echo "ok - File uploaded sucessfully"
else
    echo "not ok - File not found!"
fi

### SETTING UP INSTRUCTIONS
# - Add this file in `~/Documents` and create a folder by name `DataBakcup`
# - Set up a CRON job to run this script daily using
# `crontab -e` (This will open an editable file in the detault text editor)
# -  Add the  following line at the bottom of the file, save & exit
# `55 23 * * * /home/cocoproducts/Documents/backup_upload.sh` 
# - This will run this script at 11:55 PM everyday
