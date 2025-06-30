#!/bin/sh
# Copy React build output to ASP.NET wwwroot
rm -rf ../PowerHouse/wwwroot/*
cp -r build/* ../PowerHouse/wwwroot/
