#!/bin/bash

if [ -f MODIFICATIONS.md ] ; then rm MODIFICATIONS.md; fi

html-diff !!commit!! > MODIFICATIONS.html
git add MODIFICATIONS.html